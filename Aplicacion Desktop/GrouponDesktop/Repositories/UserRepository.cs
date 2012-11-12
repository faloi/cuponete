using System;
using System.Data.SqlClient;
using GrouponDesktop.DTOs;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Repositories
{
    public class UserRepository
    {
        private readonly SqlRunner sqlRunner;

        public UserRepository(string connectionString)
        {
            this.sqlRunner = new SqlRunner(connectionString);
        }

        public void Login(Usuario usuario)
        {
            var result = 
                this.sqlRunner.Single("SELECT username, password, fallas FROM RANDOM.Usuario WHERE username = {0}", usuario.username);

            if (result == null)    
                throw new ApplicationException("El usuario no existe");

            var userFromDb = new Adapter().Transform<Usuario>(result);

            if (userFromDb.EstaBloqueado)
                throw new ApplicationException("El usuario se encuentra bloqueado");

            if (userFromDb.password != usuario.password)
            {
                this.IncrementarFallas(usuario);
                throw new ApplicationException("Password incorrecto");
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
                return Runnable.StoreProcedure("IncrementarFallas", new[] { new SqlParameter("@username", usuario.username) });
            }
        }
    }
}
