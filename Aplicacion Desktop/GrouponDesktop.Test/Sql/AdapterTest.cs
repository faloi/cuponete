using System.Data;
using System.Linq;
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
    }
}
