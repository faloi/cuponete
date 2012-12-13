using System.Collections.Generic;
using System.Windows.Forms;
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
            this.tipoUsuarioDisponible = ADMINISTRADOR;
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

            this.buttonNuevoProveedor.Click +=
                (sender, args) => this.Nuevo();

            this.buttonModificar.Click +=
                (sender, args) => this.Modificar();

            this.buttonBajaRestaurar.Click +=
                (sender, args) => this.BajaRestaurar();
        }

        private void BajaRestaurar()
        {
            var proveedor = this.home.GetProveedorById(this.IdSeleccionado);
            if (proveedor.estado == 0)
            {
                this.home.DarDeAltaUsuario(proveedor);
                MessageBox.Show("El proveedor se Habilito con éxito");
            }
            else
            {
                this.home.DarDeBajaUsuario(proveedor);
                MessageBox.Show("El proveedor se Deshabilito con éxito");
            }
        }

        private void Nuevo()
        {
            new ModificarProveedor().ShowDialog();
            this.ExecSubmit();
        }

        private void Modificar()
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
