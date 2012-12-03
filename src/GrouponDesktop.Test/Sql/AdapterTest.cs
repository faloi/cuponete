using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using GrouponDesktop.DTOs;
using GrouponDesktop.Sql;
using GrouponDesktop.Test.Helpers;
using Xunit;

namespace GrouponDesktop.Test.Sql
{
    public class AdapterTest
    {
        [Fact]
        public void Can_correctly_map_data_row_to_class_with_public_getters()
        {            
            var dataColumns = new[] {"username", "password", "dni_cuit", "fallas"}
                .Select(name => new DataColumn(name))
                .ToArray();

            var dataTable = new DataTable();
            dataTable.Columns.AddRange(dataColumns);
            
            var row = dataTable.NewRow();
            row["username"] = "faloi";
            row["password"] = "12345";
            row["dni_cuit"] = "36528600";
            row["fallas"] = 2;

            var adapter = new Adapter();
            
            var adaptedUser = adapter.Transform<Usuario>(row);
            var expectedUser = new Usuario {username = "faloi", password = "12345", dni_cuit = "36528600", fallas = 2};

            UnitTestingHelper.AssertPublicPropertiesEqual(expectedUser, adaptedUser);
        }

        [Fact]
        public void Can_correctly_create_sql_parameters_from_typed_object()
        {
            var usuario = new Cliente {dni_cuit = "36528600", fallas = 1, username = "faloi", fecha_nac = new DateTime(2000, 10, 25)};
            var parameters = new Adapter().CreateParametersFrom(usuario);

            parameters.AssertContains("dni_cuit", "36528600");
            parameters.AssertContains("fallas", 1);
            parameters.AssertContains("username", "faloi");
            parameters.AssertContains("fecha_nac", new DateTime(2000, 10, 25));
        }
        
        [Fact]
        public void Can_correctly_create_sql_parameters_from_dictionary()
        {
            var parameters = new Adapter().CreateParametersFrom(new Dictionary<string, object> { { "id", 3 }, { "description", "Nuevo" } });

            Assert.Equal(2, parameters.Count());

            parameters.AssertContains("id", 3);
            parameters.AssertContains("description", "Nuevo");
        }

        [Fact]
        public void Creating_parameters_should_only_include_the_specified_parameters()
        {
            var proveedor = new Proveedor {cod_postal = 55, mail = "fafaf@a.com", fallas = 3};
            var parameters = new Adapter().CreateParametersFrom(proveedor, "cod_postal", "mail");

            Assert.Equal(2, parameters.Count());
            Assert.False(parameters.Any(p => p.ParameterName == "fallas"));
        }
    }

    public static class TestingHelpers
    {
        public static void AssertContains<T>(this IEnumerable<SqlParameter> parameters, string name, T value)
        {
            Assert.True(parameters.Any(p => p.ParameterName == name && (ChangeType<T>(p)).Equals(value)));
        }

        private static object ChangeType<T>(SqlParameter p)
        {
            return Convert.ChangeType(p.Value, typeof(T));
        }
    }
}
