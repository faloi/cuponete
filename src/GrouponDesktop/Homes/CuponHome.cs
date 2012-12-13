using System;
using System.Collections.Generic;
using GrouponDesktop.DTOs;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Homes
{
    public class CuponHome : Home
    {
        private const string DATE_FORMAT = "yyyy-MM-dd";
        
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
                "ComprarCupon", cuponComprado, "id_cliente", "id_cupon", "fecha_compra", "codigo_compra");
            this.Run(procedure);
        }

        public IList<Cupon_comprado> CuponesComprados(Cupon_comprado example)
        {
            const string QUERY =
                @"select fecha_compra, descripcion, codigo_compra, precio_real, estado 
                from RANDOM.Historial_Compra_Cupones";

            var filters = new Filters()
                .AddEqual("id_cliente", HomeFactory.Usuario.UsuarioActual.id_usuario.ToString())
                .AddGreaterThanOrEqual("fecha_compra", example.FechaDesde.ToString(DATE_FORMAT))
                .AddLessThanOrEqual("fecha_compra", example.FechaHasta.ToString(DATE_FORMAT));

            return new Adapter().TransformMany<Cupon_comprado>(this.sqlRunner.Select(QUERY, filters));
        }

        public IList<ProveedorFacturacion> CuponesParaFacturar(ProveedorFacturacion filter)
        {
            const string QUERY =
               @"select codigo_compra, fecha_canje, precio_real 
                from RANDOM.Facturacion_Proveedor";

            var filters = new Filters()
                .AddEqual("id_proveedor", filter.id_proveedor)
                .AddGreaterThanOrEqual("fecha_canje", filter.fecha_inicio.ToString(DATE_FORMAT))
                .AddLessThanOrEqual("fecha_canje", filter.fecha_fin.ToString(DATE_FORMAT));

            return new Adapter().TransformMany<ProveedorFacturacion>(this.sqlRunner.Select(QUERY, filters));
        }

        public void Facturar(ProveedorFacturacion example)
        {
            var procedure = this.CreateProcedureFrom(
                "Facturacion_Proveedor",
                example,
                "monto_total", "nro_factura", "id_proveedor", "fecha", "fecha_inicio", "fecha_fin");

            this.Run(procedure);
        }
    }
}
