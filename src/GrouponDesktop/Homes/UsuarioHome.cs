using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GrouponDesktop.DTOs;
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

                if (userFromDb.password != usuario.password)
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
            this.sqlRunner.Run(Queries.IncrementarFallas(usuario));
        }

        private static class Queries
        {
            public static Runnable IncrementarFallas(Usuario usuario)
            {
                return Runnable.StoreProcedure("RANDOM.IncrementarFallas", new[] { new SqlParameter("@userId", usuario.id_usuario) });
            }
        }

        public void RegistrarCliente(Cliente cliente, IEnumerable<Ciudad> ciudades)
        {
            this.RunProcedure("RegistrarCliente", cliente, 
                "username", "password", "nombre", "apellido", "mail", "dni", "telefono", "direccion_completa", "cod_postal", "fecha_nac");

            foreach (var ciudad in ciudades)
                this.RunProcedure("AgregarClientePorCiudad", new Dictionary<string, object>
                                      {{"dni", cliente.dni}, {"id_ciudad", ciudad.id_ciudad}});
        }

        public void RegistrarProveedor(Proveedor proveedor)
        {
            this.RunProcedure("RegistrarProveedor", proveedor);
        }

        public IList<Cliente> ListarClientes(Cliente ejemplo)
        {
            const string QUERY = "SELECT nombre, apellido, dni, mail FROM RANDOM.Cliente";

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
            const string QUERY = "SELECT razon_social, cuit,mail FROM RANDOM.Proveedor";

            var filtros = new Filters();
            if (ejemplo.razon_social != null)
                filtros.AddLike("razon_social", ejemplo.razon_social);
            if (ejemplo.cuit != null)
                filtros.AddEqual("cuit", ejemplo.cuit);
            if (ejemplo.mail != null)
                filtros.AddLike("mail", ejemplo.mail);

            return new Adapter().TransformMany<Proveedor>(this.sqlRunner.Select(QUERY, filtros));
        }
    }
}
