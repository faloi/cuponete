using System;
using System.Collections.Generic;
using System.Data;
using GrouponDesktop.DTOs;
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

        public DataTable CiudadesDisponiblesParaCliente()
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

        public IEnumerable<Ciudad> CiudadesPorCliente(long id_cliente)
        {
            const string QUERY = "SELECT ciu.descripcion FROM RANDOM.Cliente_x_ciudad cliciu LEFT JOIN RANDOM.Ciudad ciu ON (ciu.id_ciudad = cliciu.id_ciudad)";

            var filtros = new Filters();
            filtros.AddEqual("id_cliente", id_cliente.ToString());

            return new Adapter().TransformMany<Ciudad>(this.sqlRunner.Select(QUERY, filtros));
        }

/*
        private static class Queries
        {

        }
*/
    }
}
