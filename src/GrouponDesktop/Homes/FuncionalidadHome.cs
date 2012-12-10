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

        public DataTable FuncionalidadesDisponiblesParaRol(long id_rol)
        {
            try
            {
                var filtros = new Filters();
                filtros.AddEqual("id_rol", id_rol.ToString());
                return sqlRunner
                    .Select("SELECT * FROM RANDOM.Funcionalidad", filtros);
            }
            catch (NoResultsException e)
            {
                throw new ApplicationException("No hay Resultados", e);
            }
        }
    }
}
