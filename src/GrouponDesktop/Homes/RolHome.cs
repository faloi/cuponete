using System;
using System.Collections.Generic;
using System.Data;
using GrouponDesktop.DTOs;
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


        public void RegistrarRol(Rol rol, IEnumerable<Funcionalidad> funcionalidades)
        {
            this.RunProcedure("AgregarRol", rol,
                "descripcion");

            foreach (var funcionalidad in funcionalidades)
                this.RunProcedure("AgregarFuncionalidadPorRol", new Dictionary<string, object> { { "id_funcionalidad", funcionalidad.id_funcionalidad }, { "id_rol", rol.id_rol } });
        }

/*
        private static class Queries
        {

        }
*/
    }
}
