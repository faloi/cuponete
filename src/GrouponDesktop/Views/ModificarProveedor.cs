using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Views
{
    public partial class ModificarProveedor : DefaultView
    {
        private readonly UsuarioHome home;
        private bool IsNew { get; set; }

        public ModificarProveedor() : this(new Proveedor(), true) {}

        public ModificarProveedor(Proveedor proveedor) : this(proveedor, false) {}

        private ModificarProveedor(Proveedor proveedor, bool isNew)
        {
            InitializeComponent();

            this.IsNew = isNew;
            this.usuarioGroupBox.Visible = this.limpiarButton.Visible = this.IsNew;

            this.home = HomeFactory.Usuario;
            this.SetBindingSource(proveedor);

            this.Text = "Modificar Proveedor";
            this.CreateBindings(this.guardarButton);
            this.password.UseSystemPasswordChar = true;
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

            if (this.IsNew)
            {
                this.username.BindTextTo(this.model, "username");
                this.password.BindTextTo(this.model, "password");
            }
            
            this.CargarRubros();
            this.CargarCiudadesProv();
        }

        protected override void ExecSubmit()
        {
            var proveedor = this.model.DataSource as Proveedor;

            if (this.IsNew)
                this.home.RegistrarProveedor(proveedor);
            else
                this.home.ModificarProveedor(proveedor);

            this.Close();
        }

        private void CargarRubros()
        {
            var rubros = new Adapter().TransformMany<Rubro>(HomeFactory.Rubro.RubrosDisponibles());
            this.comboRubro.BindSourceTo(rubros, "id_rubro", "desc_rubro");
            this.comboRubro.BindValueTo(this.model, "id_rubro");
        }

        private void CargarCiudadesProv()
        {
            var ciudades = new Adapter().TransformMany<Ciudad>(HomeFactory.Ciudad.CiudadesDisponibles());
            this.ciudadProvCombo.BindSourceTo(ciudades, "id_ciudad", "descripcion");
            this.ciudadProvCombo.BindValueTo(this.model, "id_ciudad");
        }
    }
}
