using System;
using System.Collections.Generic;
using System.Linq;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Homes
{
    public class CuponHome : Home
    {
        private const string DATE_FORMAT = "s";
        
        public CuponHome(string connectionString) : base(connectionString) {}

        public IList<Cupon> CuponesDisponibles(DateTime fecha)
        {
            const string QUERY = "SELECT id_cupon,descripcion,precio_real,precio_ficticio FROM RANDOM.Cupones_Para_Cliente";

            var filtros = new Filters()
                .AddEqual("id_cliente",HomeFactory.Usuario.UsuarioActual.id_usuario.ToString())
                .AddGreaterThanOrEqual("fec_venc_publicacion",fecha.ToString(DATE_FORMAT))
                .AddLessThanOrEqual("fec_publicacion", fecha.ToString(DATE_FORMAT));

            return new Adapter().TransformMany<Cupon>(this.sqlRunner.Select(QUERY, filtros));
        }

        public Cupon GetCuponById(string idSeleccionado)
        {
            const string QUERY = "SELECT * FROM RANDOM.Cupon where id_cupon = {0}";
            return new Adapter().Transform<Cupon>(this.sqlRunner.Single(QUERY, idSeleccionado));
        }

        public void ComprarCupon(Cupon_comprado cuponComprado)
        {
            var procedure = this.CreateProcedureFrom(
                "ComprarCupon", cuponComprado, "id_cliente", "id_cupon", "fecha_compra", "id_compra");

            cuponComprado.codigo_compra = this.Run(procedure).GetValue("id_compra");

        }

        public IList<Cupon_comprado> CuponesComprados(Cupon_comprado example)
        {
            const string QUERY =
                @"select fecha_compra,fec_venc_consumo, descripcion, codigo_compra, precio_real, estado 
                from RANDOM.Historial_Compra_Cupones";

            var filters = new Filters()
                .AddEqual("id_cliente", HomeFactory.Usuario.UsuarioActual.id_usuario.ToString())
                .AddGreaterThanOrEqual("fecha_compra", example.FechaDesde.ToString(DATE_FORMAT))
                .AddLessThanOrEqual("fecha_compra", example.FechaHasta.ToString(DATE_FORMAT));

            return new Adapter().TransformMany<Cupon_comprado>(this.sqlRunner.Select(QUERY, filters));
        }

        public IList<Factura> CuponesParaFacturar(Factura filter)
        {
            const string QUERY =
               @"select codigo_compra, fecha_canje, precio_real 
                from RANDOM.Facturacion_Proveedor";

            var filters = new Filters()
                .AddEqual("id_proveedor", filter.id_proveedor.ToString())
                .AddGreaterThanOrEqual("fecha_canje", filter.fecha_inicio.ToString(DATE_FORMAT))
                .AddLessThanOrEqual("fecha_canje", filter.fecha_fin.ToString(DATE_FORMAT));

            return new Adapter().TransformMany<Factura>(this.sqlRunner.Select(QUERY, filters));
        }

        public void Facturar(Factura example)
        {
            var procedure = this.CreateProcedureFrom(
                "FacturarCupones",
                example,
                "monto_total", "nro_factura", "id_proveedor", "fecha", "fecha_inicio", "fecha_fin");

            this.Run(procedure);
        }

        public void ArmarCupon(Cupon cupon, IEnumerable<Ciudad> ciudadesSeleccionadas)
        {

            var procedures = new List<Runnable>
            {
                this.CreateProcedureFrom("ArmarCupon",cupon, "id_cupon",
                    "id_proveedor","descripcion", "fecha_actual", "fec_publicacion", "fec_venc_publicacion", "fec_venc_consumo",
                    "precio_real", "precio_ficticio", "cant_disp", "max_compra_por_usuario")
            };

            var relacionCiudades = ciudadesSeleccionadas
                .Select(ciudad =>
                    this.CreateProcedureFrom("AgregarCuponPorCiudad", new[] { "id_cupon" },
                    new Dictionary<string, object> { { "id_cupon", cupon.id_cupon }, { "id_ciudad", ciudad.id_ciudad } }));

            procedures.AddRange(relacionCiudades);

            this.Run(procedures);
        }

        public IList<Cupon> CuponesParaPublicar(Cupon cupon)
        {
            const string QUERY = "SELECT cup.id_cupon,prov.razon_social as descripcionProveedor,cup.descripcion,cup.precio_real,cup.cant_disp " +
                                 "FROM RANDOM.Cupon cup " +
                                 "INNER JOIN RANDOM.Proveedor prov ON prov.id_usuario=cup.id_proveedor";

            var filtros = new Filters()
                .AddEqual("publicado", "0")
                .AddEqual("fec_publicacion", cupon.fec_publicacion.ToString(DATE_FORMAT));
            
            if (cupon.id_proveedor != 0)
                filtros.AddEqual("id_proveedor", cupon.id_proveedor.ToString());

            if (cupon.descripcion != null)
                filtros.AddLike("descripcion", cupon.descripcion);

            return new Adapter().TransformMany<Cupon>(this.sqlRunner.Select(QUERY, filtros));
        }


        public void Publicar(Cupon filter)
        {
            var procedure = this.CreateProcedureFrom("PublicarCupon",filter,"id_cupon");

            this.Run(procedure);
            
        }

        public void PedirDevolucion(CuponParaDevolucion cuponParaDevolucion)
        {
            var procedure = this.CreateProcedureFrom("PedirDevolucionCupon", cuponParaDevolucion, "id_cliente", "fecha_devolucion",
             "id_compra", "codigo_compra", "id_cupon");

           var results =  this.Run(procedure);
            cuponParaDevolucion.id_cupon = Convert.ToInt32(results.GetValue("id_cupon"));
            cuponParaDevolucion.id_compra = Convert.ToInt32(results.GetValue("id_compra"));
            cuponParaDevolucion.codigo_compra = results.GetValue("id_compra");

        }

        public CuponParaDevolucion GetCuponParaDevolucion(CuponParaDevolucion cuponParaDevolucion)
        {
            const string QUERY = "SELECT id_cupon,descripcion,fec_venc_consumo,precio_real FROM RANDOM.Cupon where id_cupon = {0}";

            var cupon = new Adapter().Transform<CuponParaDevolucion>(this.sqlRunner.Single(QUERY, cuponParaDevolucion.id_cupon.ToString()));
            cuponParaDevolucion.id_cupon = cupon.id_cupon;
            cuponParaDevolucion.descripcion = cupon.descripcion;
            cuponParaDevolucion.fec_venc_consumo = cupon.fec_venc_consumo;
            cuponParaDevolucion.precio_real = cupon.precio_real;
            return cuponParaDevolucion;
        }

         public void RegistrarConsumo(Cupon_canjeado cupon)
        {
            var procedure = this.CreateProcedureFrom("RegistrarConsumo", cupon, "id_proveedor", "codigo_compra", "fecha_canje");
            this.Run(procedure);
        }

        public void DevolverCupon(CuponParaDevolucion cuponParaDevolucion)
        {
            var procedure = this.CreateProcedureFrom("DevolverCupon", cuponParaDevolucion, "id_cliente", "fecha_devolucion", "codigo_compra", "motivo_devolucion");

            this.Run(procedure);
        }
    }
}
