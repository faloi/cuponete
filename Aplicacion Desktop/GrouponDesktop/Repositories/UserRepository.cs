﻿using System;
using System.Data.SqlClient;
using GrouponDesktop.DTOs;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Repositories
{
    public class UserRepository : Repository
    {
        public UserRepository(string connectionString) : base(connectionString) {}

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
                    this.IncrementarFallas(usuario);
                    throw new ApplicationException("Password incorrecto");
                }
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
                return Runnable.StoreProcedure("IncrementarFallas", new[] { new SqlParameter("@username", usuario.username) });
            }
        }
    }
}
