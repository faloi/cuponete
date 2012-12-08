using System;
using System.Data;
using GrouponDesktop.DTOs;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Homes
{
    public class GiftCardHome : Home
    {
        public GiftCardHome(string connectionString)
            : base(connectionString)
        {
            
        }

        public Usuario IdDesdeUsername(string username)
        {
            var result = this.sqlRunner
                    .Single("SELECT * FROM RANDOM.Usuario WHERE username = '{0}'", username);

            return new Adapter().Transform<Usuario>(result);
        }

/*
        private static class Queries
        {

        }
*/
    }
}
