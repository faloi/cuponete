using System;
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

        private string IdSeleccionado
       {
           get { return Convert.ToString((this.proveedoresDataGrid.GetValue() as Proveedor).id_usuario); }
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
            this.Data = this.home.ListarProveedores(this.Filter as Proveedor);
        }
    }
}
