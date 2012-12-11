using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using GrouponDesktop.Sql;
using Xunit;

namespace GrouponDesktop.Test.Sql
{
    public class RunnableTest
    {
        private IEnumerable<SqlParameter> CreateParametersFrom(Dictionary<string, object> keysAndValues)
        {
            return keysAndValues.Select(item => new SqlParameter(item.Key, item.Value));
        }

        [Fact]
        public void Update_parameters_from_should_replace_the_values_of_the_repeated_parameters()
        {
            var firstParameters = this.CreateParametersFrom(new Dictionary<string, object> { {"Price", 15}, {"Id", "Potatoes3356"} });
            var firstProcedure = Runnable.StoreProcedure("TheFirstOne", firstParameters);

            var secondParameters = this.CreateParametersFrom(new Dictionary<string, object> {{"Price", 30}, {"Id", "1324567"}});
            var secondProcedure = Runnable.StoreProcedure("TheSecondOne", secondParameters);

            secondProcedure.UpdateParametersFrom(firstProcedure);

            Assert.Equal(15, secondProcedure.GetParameterValue("Price"));
            Assert.Equal("Potatoes3356", secondProcedure.GetParameterValue("Id"));
        }

        [Fact]
        public void Update_parameters_from_should_ignore_the_different_parameters()
        {
            var firstParameters = this.CreateParametersFrom(new Dictionary<string, object> { {"Price", 15}, {"Desc", "Potatoes3356"} });
            var firstProcedure = Runnable.StoreProcedure("TheFirstOne", firstParameters);

            var secondParameters = this.CreateParametersFrom(new Dictionary<string, object> {{"Quantity", 30}, {"Id", "1324567"}});
            var secondProcedure = Runnable.StoreProcedure("TheSecondOne", secondParameters);

            secondProcedure.UpdateParametersFrom(firstProcedure);

            Assert.Equal(30, secondProcedure.GetParameterValue("Quantity"));
            Assert.Equal("1324567", secondProcedure.GetParameterValue("Id"));
        }
    }
}
