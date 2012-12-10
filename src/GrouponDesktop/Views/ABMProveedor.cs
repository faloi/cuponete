using System.Collections.Generic;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class ABMProveedor : ListadoView
    {
        private readonly UsuarioHome home;

        public ABMProveedor()
        {
            InitializeComponent();
            this.home = HomeFactory.Usuario;
            this.Example = new Proveedor();

            this.Setup();
        }

        private void Setup()
        {
            this.rolDisponible = ADMINISTRADOR;
            this.Text = "Listado de Proveedores";
            this.CreateBindings(this.buttonBuscar);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxRazonSocial.BindTextTo(this.Example, "razon_social");
            this.textBoxCuit.BindTextTo(this.Example, "cuit");
            this.textBoxEmail.BindTextTo(this.Example, "mail");

            this.proovedoresDataGrid.BindSourceTo(this.Data, new Dictionary<string, string>
            {
                {"Razon Social", "razon_social"},
                {"CUIT", "cuit"},
                {"Email", "mail"}
            });

            this.limpiarButton.Click +=
                (sender, args) => this.Example = new Proveedor();
        }

        protected override void ExecSubmit()
        {
            this.Data = this.home.ListarProveedores(this.Filter as Proveedor);
        }
    }
}
