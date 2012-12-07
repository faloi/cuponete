using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using Xunit;

namespace GrouponDesktop.Test.Helpers
{
    public class ReflectionHelpersTest
    {
        [Fact]
        public void Set_property_should_change_the_value_if_the_property_exists()
        {
            var cliente = new Cliente {apellido = "Aloi", cod_postal = 1406};
            
            cliente.SetPropertyIfExists("apellido", "Gonzalez");
            cliente.SetPropertyIfExists("cod_postal", 1125);

            Assert.Equal("Gonzalez", cliente.apellido);
            Assert.Equal(1125, cliente.cod_postal);
        }

        [Fact]
        public void Set_property_shouldnt_do_anything_if_it_doesnt_exist()
        {
            var cliente = new Cliente();
            Assert.DoesNotThrow(() => cliente.SetPropertyIfExists("sarasa", 15));
        }
    }
}
