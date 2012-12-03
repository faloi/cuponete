using System;
using System.Data;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Homes
{
    public class RolHome : Home
    {

        public RolHome(string connectionString)
            : base(connectionString)
        {
            
        }


        public DataTable RolesDisponibles()
        {
            try
            {
                return sqlRunner
                    .Select("SELECT * FROM RANDOM.Rol WHERE descripcion != 'Administrador'");
            }
            catch (NoResultsException e)
            {
                throw new ApplicationException("No hay roles Disponibles", e);
            }
            
        }

/*
        private static class Queries
        {

        }
*/
    }
}
