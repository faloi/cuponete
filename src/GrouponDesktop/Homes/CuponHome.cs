using System;
using System.Collections.Generic;
using System.Data;
using GrouponDesktop.DTOs;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Homes
{
    public class CuponHome : Home
    {

        public CuponHome(string connectionString)
            : base(connectionString)
        {

        }

        public IList<Cupon> CuponesDisponibles()
        {
            const string QUERY = "SELECT descripcion,precio_real,precio_ficticio FROM RANDOM.Cupones_Para_Cliente";

            var filtros = new Filters();
            filtros.AddEqual("id_cliente",HomeFactory.Usuario.UsuarioActual.id_usuario.ToString());

            return new Adapter().TransformMany<Cupon>(this.sqlRunner.Select(QUERY, filtros));
        }

        /*
                private static class Queries
                {

                }
        */
    }
}
