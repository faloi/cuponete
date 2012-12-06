using System;
using System.Data;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Homes
{
    public class RubroHome : Home
    {

        public RubroHome(string connectionString)
            : base(connectionString)
        {
            
        }


        public DataTable RubrosDisponibles()
        {
            try
            {
                return sqlRunner
                    .Select("SELECT * FROM RANDOM.Rubro");
            }
            catch (NoResultsException e)
            {
                throw new ApplicationException("No hay Resultados", e);
            }
            
        }

/*
        private static class Queries
        {

        }
*/
    }
}
