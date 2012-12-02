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
            this.RunProcedure("RegistrarCliente", cliente);

            foreach (var ciudad in ciudades)
                this.RunProcedure("AgregarClientePorCiudad", new { id_cliente = cliente.id_usuario, id_ciudad = ciudad.id_ciudad });
        }

        public void RegistrarProveedor(Proveedor proveedor)
        {
            this.RunProcedure("RegistrarProveedor", proveedor);
        }
    }
}
