using System.Collections.Generic;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class ABMProveedor : ListadoView<Proveedor>
    {
        private readonly UsuarioHome home;

        public ABMProveedor()
        {
            this.InitializeComponent();
            this.home = HomeFactory.Usuario;
            this.Setup();
        }

        private string IdSeleccionado
       {
           get { return this.proveedoresDataGrid.GetSelectedItem<Proveedor>().id_usuario.ToString(); }
       }

        private void Setup()
        {
            this.rolDisponible = ADMINISTRADOR;
            this.Text = "Listado de Proveedores";
            this.CreateBindings(this.buttonBuscar, this.limpiarButton, this.buttonModificar, this.buttonBajaRestaurar, this.proveedoresDataGrid);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxRazonSocial.BindTextTo(this.Example, "razon_social");
            this.textBoxCuit.BindTextTo(this.Example, "cuit");
            this.textBoxEmail.BindTextTo(this.Example, "mail");

            this.proveedoresDataGrid.BindSourceTo(this.Data,"id_usuario", new Dictionary<string, string>
            {
                {"Razon Social", "razon_social"},
                {"CUIT", "cuit"},
                {"Email", "mail"}
            });

            this.limpiarButton.Click +=
                (sender, args) => this.Example = new Proveedor();

            this.buttonModificar.Click +=
                (sender, args) => this.ModificarProveedor();
        }

        private void ModificarProveedor()
        {
            var proveedor = this.home.GetProveedorById(this.IdSeleccionado);
            new ModificarProveedor(proveedor).ShowDialog();

            this.ExecSubmit();
        }

        protected override void ExecSubmit()
        {
            this.Data = this.home.ListarProveedores(this.Filter);
        }
    }
}
