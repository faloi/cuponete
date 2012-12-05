using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            var procedures = new List<Runnable>
            {
                this.CreateProcedureFrom("AgregarRol", rol, "descripcion")
            };

            var nuevasFuncionalidades = funcionalidades
                .Select(funcionalidad =>
                    this.CreateProcedureFrom("AgregarFuncionalidadPorRol",
                    new Dictionary<string, object> { { "id_funcionalidad", funcionalidad.id_funcionalidad }, { "id_rol", rol.id_rol } }));

            procedures.AddRange(nuevasFuncionalidades);

            this.RunProcedures(procedures);
        }
    }
}
