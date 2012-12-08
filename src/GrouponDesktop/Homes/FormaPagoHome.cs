using System;
using System.Data;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Homes
{
    public class FormaPagoHome : Home
    {

        public FormaPagoHome(string connectionString)
            : base(connectionString)
        {
            
        }


        public DataTable FormaPagoDisponibles()
        {
            try
            {
                return sqlRunner
                    .Select("SELECT * FROM RANDOM.Forma_de_Pago");
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
