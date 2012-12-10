using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                    throw new ApplicationException("El usuario se encuentra bloqueado");

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
            var procedure = 
                this.CreateProcedureFrom("IncrementarFallas", new Dictionary<string, object> {{"@userId", usuario.id_usuario}});
            
            this.RunProcedure(procedure);
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
                    this.CreateProcedureFrom("AgregarClientePorCiudad", 
                    new Dictionary<string, object> {{"id_cliente", cliente.id_usuario}, {"id_ciudad", ciudad.id_ciudad}}));
            
            procedures.AddRange(relacionCiudades);

            this.RunProcedures(procedures);
        }

        public void RegistrarProveedor(Proveedor proveedor)
        {
            this.CreateProcedureFrom("RegistrarProveedor", proveedor);
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

        public void BorrarCliente(string id)
        {
            throw new NotImplementedException();
        }
    }
}
