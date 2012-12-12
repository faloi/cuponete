using System;
using System.Collections.Generic;
using GrouponDesktop.DTOs;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Homes
{
    public class FuncionalidadHome : Home
    {
        public FuncionalidadHome(string connectionString) : base(connectionString) {}

        public IList<Funcionalidad> FuncionalidadesDisponibles()
        {
            try
            {
                return new Adapter().TransformMany<Funcionalidad>(sqlRunner.Select("SELECT * FROM RANDOM.Funcionalidad"));
            }
            catch (NoResultsException e)
            {
                throw new ApplicationException("No hay Resultados", e);
            }
        }

        public IEnumerable<Funcionalidad> FuncionalidadesPorRol(long id_rol)
        {
            const string QUERY = "SELECT func.descripcion FROM RANDOM.Funcionalidad_x_Rol funcr LEFT JOIN RANDOM.Funcionalidad func ON (func.id_funcionalidad = funcr.id_funcionalidad)";

            var filtros = new Filters();
            if (id_rol != 0)
                filtros.AddEqual("id_rol", id_rol.ToString());

            return new Adapter().TransformMany<Funcionalidad>(this.sqlRunner.Select(QUERY, filtros));
        }
    }
}
