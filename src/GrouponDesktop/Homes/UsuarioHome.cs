using System;
using System.Collections.Generic;
using System.Linq;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Homes
{
    public class UsuarioHome : Home
    {
        public Usuario UsuarioActual;
        
        public UsuarioHome(string connectionString) : base(connectionString)
        {
            this.UsuarioActual = new Usuario();
        }

        public void Login(Usuario usuario)
        {
            try
            {
                var result = this.sqlRunner
                    .Single("SELECT * FROM RANDOM.Usuario WHERE username = '{0}'", usuario.username);

                var userFromDb = new Adapter().Transform<Usuario>(result);

                if (userFromDb.EstaBloqueado)
                    throw new ApplicationException("El usuario se encuentra bloqueado.");
                
                if(userFromDb.id_rol==0)
                    throw new ApplicationException("El usuario no tiene un rol asignado. Contáctese con el administrador.");

                if (userFromDb.password != usuario.password.ToSha256())
                {
                    this.IncrementarFallas(userFromDb);
                    throw new ApplicationException("Password incorrecto");
                }

                this.UsuarioActual = userFromDb;
            }
            catch (NoResultsException e)
            {
                throw new ApplicationException("El usuario no existe", e);
            }            
        }

        private void IncrementarFallas(Usuario usuario)
        {
            var procedure = this.CreateProcedureFrom("IncrementarFallas", new Dictionary<string, object> {{"@id_usuario", usuario.id_usuario}});
            this.Run(procedure);
        }

        public void RegistrarCliente(Cliente cliente, IEnumerable<Ciudad> ciudades)
        {
            cliente.password = cliente.password.ToSha256();

            var procedures = new List<Runnable>
            {
                this.CreateProcedureFrom("RegistrarCliente", cliente,
                    "id_usuario","username", "password", "nombre", "apellido", "mail",
                    "dni", "telefono", "direccion_completa", "cod_postal",
                    "fecha_nac")
            };

            var relacionCiudades = ciudades
                .Select(ciudad => 
                    this.CreateProcedureFrom("AgregarClientePorCiudad", new[] { "id_usuario" },
                    new Dictionary<string, object> {{"id_usuario", cliente.id_usuario}, {"id_ciudad", ciudad.id_ciudad}}));
            
            procedures.AddRange(relacionCiudades);

            this.Run(procedures);
        }

        public void RegistrarProveedor(Proveedor proveedor)
        {
            proveedor.password = proveedor.password.ToSha256();

            var procedure = this.CreateProcedureFrom(
                "RegistrarProveedor", proveedor, "username", "password", "razon_social", "mail", 
                "telefono", "direccion", "cod_postal", "id_ciudad", "cuit", "id_rubro", "contacto_nombre");
            this.Run(procedure);
        }

        public void ComprarGiftCard(Gift_card gift)
        {
            var procedure = this.CreateProcedureFrom("ComprarGiftCard", gift, "id_usuario_origen", "id_usuario_destino", "fecha", "monto");
            this.Run(procedure);
        }

        public IList<Cliente> ListarClientes(Cliente ejemplo)
        {
            const string QUERY = "SELECT id_usuario, nombre, apellido, dni, mail FROM RANDOM.Cliente";

            var filtros = new Filters();
            if (ejemplo.nombre != null)
                filtros.AddLike("nombre", ejemplo.nombre);
            if (ejemplo.apellido != null)
                filtros.AddLike("apellido", ejemplo.apellido);
            if (ejemplo.mail != null)
                filtros.AddLike("mail", ejemplo.mail);
            if (ejemplo.dni != 0)
                filtros.AddEqual("dni", ejemplo.dni.ToString());

            return new Adapter().TransformMany<Cliente>(this.sqlRunner.Select(QUERY, filtros));
        }

        public IList<Proveedor> ListarProveedores(Proveedor ejemplo)
        {
            const string QUERY = "SELECT * FROM RANDOM.Proveedor";

            var filtros = new Filters();
            if (ejemplo.razon_social != null)
                filtros.AddLike("razon_social", ejemplo.razon_social);
            if (ejemplo.cuit != null)
                filtros.AddEqual("cuit", ejemplo.cuit);
            if (ejemplo.mail != null)
                filtros.AddLike("mail", ejemplo.mail);

            return new Adapter().TransformMany<Proveedor>(this.sqlRunner.Select(QUERY, filtros));
        }

        public Cliente GetClienteById(string id_usuario)
        {
            const string QUERY = "SELECT * FROM RANDOM.Cliente where id_usuario = {0}";
            return new Adapter().Transform<Cliente>(this.sqlRunner.Single(QUERY, id_usuario));
        }

        public Proveedor GetProveedorById(string id_usuario)
        {
            const string QUERY = "SELECT * FROM RANDOM.Proveedor where id_usuario = {0}";
            return new Adapter().Transform<Proveedor>(this.sqlRunner.Single(QUERY, id_usuario));
        }

        public Cliente GetClienteByUserName(string username)
        {
           try
           {
               const string QUERY = 
                   "SELECT cli.* FROM RANDOM.Cliente cli LEFT JOIN RANDOM.Usuario us ON (us.id_usuario=cli.id_usuario) where us.username = '{0}'";

               return new Adapter().Transform<Cliente>(this.sqlRunner.Single(QUERY, username));
           }
           catch (NoResultsException e)
           {
               throw new ApplicationException("El usuario no existe", e);
           }   
        }

        public void CambiaPassword(string nuevoPass)
        {
            HomeFactory.Usuario.UsuarioActual.password = nuevoPass.ToSha256();
            var procedure = this.CreateProcedureFrom(
                "ModificarUsuario", HomeFactory.Usuario.UsuarioActual, "id_usuario", "username", "password");

            this.Run(procedure);
        }

        public void ReiniciarFallas()
        {
            var procedure = this.CreateProcedureFrom("ReiniciarFallas", HomeFactory.Usuario.UsuarioActual, "id_usuario");
            this.Run(procedure);
        }

        public void BorrarCliente(string id)
        {
            throw new NotImplementedException();
        }

        public void CargarCredito(Credito credito)
        {
            var procedure = this.CreateProcedureFrom(
                "CargarCredito", credito, "id_cliente", "carga_credito", "fecha", "id_forma_pago", "nro_tarjeta", 
                "cod_seguridad_tarjeta", "fecha_vto_tarjeta");
            
            this.Run(procedure);
        }

        public void ModificarCliente(Cliente cliente, IEnumerable<Ciudad> ciudadesAgregadas, IEnumerable<Ciudad> ciudadesEliminadas)
        {
            var procedures = new List<Runnable>
            {
                this.CreateProcedureFrom("ModificarCliente", cliente,
                    "id_usuario", "nombre", "apellido", "mail",
                    "dni", "telefono", "direccion", "cod_postal", "fecha_nac")
            };

            var nuevasCiudades = ciudadesAgregadas.Select(ciudad =>
                    this.CreateProcedureFrom(
                    "AgregarClientePorCiudad",
                    new Dictionary<string, object> { { "id_usuario", cliente.id_usuario }, { "id_ciudad", ciudad.id_ciudad } }));

            procedures.AddRange(nuevasCiudades);

            var ciudadesViejas = ciudadesEliminadas.Select(ciudad => 
                    this.CreateProcedureFrom(
                    "QuitarClientePorCiudad",
                    new Dictionary<string, object> { { "id_usuario", cliente.id_usuario }, { "id_ciudad", ciudad.id_ciudad } }));                

            procedures.AddRange(ciudadesViejas);
            this.Run(procedures);
        }

        public void ModificarProveedor(Proveedor proveedor)
        {
            var procedure = this.CreateProcedureFrom(
                "ModificarProveedor", proveedor, "id_usuario", "razon_social", "mail", "telefono",
                "direccion", "cod_postal", "id_ciudad", "cuit", "id_rubro", "contacto_nombre");
            this.Run(procedure);
        }
    }
}
