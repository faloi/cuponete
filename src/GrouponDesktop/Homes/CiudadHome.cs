using System;
using System.Data;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Homes
{
    public class CiudadHome : Home
    {

        public CiudadHome(string connectionString)
            : base(connectionString)
        {
            
        }


        public DataTable CiudadesDisponibles()
        {
            try
            {
                return sqlRunner
                    .Select("SELECT * FROM RANDOM.Ciudad");
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
