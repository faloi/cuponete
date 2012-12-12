using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Views
{
    public partial class ModificarProveedor : DefaultView
    {
        private readonly UsuarioHome home;
            
        public ModificarProveedor(Proveedor proveedor)
        {
            InitializeComponent();

            this.home = HomeFactory.Usuario;
            this.SetBindingSource(proveedor);

            this.Text = "Modificar Proveedor";
            this.CreateBindings(this.guardarButton);
            
        }

        protected override void CreateSpecificBindings()
        {
            this.razonSocialProveedor.BindTextTo(this.model, "razon_social");
            this.emailProveedor.BindTextTo(this.model, "mail");
            this.telefonoProveedor.BindTextTo(this.model, "telefono", DataType.INTEGER);
            this.direccionProveedor.BindTextTo(this.model, "direccion");
            this.cPostalProveedor.BindTextTo(this.model, "cod_postal", DataType.INTEGER);
            this.cuitProveedor.BindTextTo(this.model, "cuit");
            this.contactoProveedor.BindTextTo(this.model, "contacto_nombre");
            this.CargarRubros();
            this.CargarCiudadesProv();
        }

        private void CargarRubros()
        {
            var rubros = new Adapter().TransformMany<Rubro>(HomeFactory.Rubro.RubrosDisponibles());
            this.comboRubro.BindSourceTo(rubros, "id_rubro", "desc_rubro");
            this.comboRubro.SelectedValue = (this.model.DataSource as Proveedor).id_rubro;

        }

        private void CargarCiudadesProv()
        {
            var ciudades = new Adapter().TransformMany<Ciudad>(HomeFactory.Ciudad.CiudadesDisponibles());
            ciudadProvCombo.BindSourceTo(ciudades, "id_ciudad", "descripcion");
            this.ciudadProvCombo.SelectedValue = (this.model.DataSource as Proveedor).id_ciudad;
        }
    }
}
