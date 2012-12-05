using System;
using System.Collections.Generic;
using System.Data;
using GrouponDesktop.DTOs;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Homes
{
    public class FuncionalidadHome : Home
    {

        public FuncionalidadHome(string connectionString)
            : base(connectionString)
        {
            
        }


        public DataTable FuncionalidadesDisponibles()
        {
            try
            {
                return sqlRunner
                    .Select("SELECT * FROM RANDOM.Funcionalidad");
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
