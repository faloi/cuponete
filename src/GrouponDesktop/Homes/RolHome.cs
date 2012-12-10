﻿using System;
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
                    .Select("SELECT * FROM RANDOM.Rol WHERE descripcion in ('Cliente','Proveedor')");
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
                this.CreateProcedureFrom("AgregarRol", rol, "id_rol","descripcion")
            };

            var nuevasFuncionalidades = funcionalidades
                .Select(funcionalidad =>
                    this.CreateProcedureFrom("AgregarFuncionalidadPorRol",
                    new Dictionary<string, object> { { "id_funcionalidad", funcionalidad.id_funcionalidad }, { "id_rol", rol.id_rol } }));

            procedures.AddRange(nuevasFuncionalidades);

            this.RunProcedures(procedures);
        }

        public IList<Rol> ListarRoles(Rol ejemplo)
        {
            const string QUERY = "SELECT * FROM RANDOM.Rol";

            var filtros = new Filters();
            if (ejemplo.descripcion != null)
                filtros.AddLike("descripcion", ejemplo.descripcion);


            return new Adapter().TransformMany<Rol>(this.sqlRunner.Select(QUERY, filtros));
        }

        public IList<Funcionalidad> Funcionalidades(long id_rol)
        {
            const string QUERY = "SELECT func.descripcion FROM RANDOM.Funcionalidad_x_Rol funcr LEFT JOIN RANDOM.Funcionalidad func ON (func.id_funcionalidad = funcr.id_funcionalidad)";

            var filtros = new Filters();
            if (id_rol != null)
                filtros.AddEqual("id_rol", id_rol.ToString());


            return new Adapter().TransformMany<Funcionalidad>(this.sqlRunner.Select(QUERY, filtros));
        }

        public Rol GetRolById(string idSeleccionado)
        {
            const string QUERY = "SELECT id_rol, descripcion FROM RANDOM.Rol where id_rol = {0}";

            return new Adapter().Transform<Rol>(this.sqlRunner.Single(QUERY, idSeleccionado));
        }
    }
}