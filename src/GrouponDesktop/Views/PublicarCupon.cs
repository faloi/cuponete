using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class PublicarCupon : ListadoView<Cupon, CuponHome>
    {
        public PublicarCupon() : base(HomeFactory.Cupon) {}

        protected override void Setup()
        {
            this.InitializeComponent();
            this.tipoUsuarioDisponible = TODOS;
            this.Text = "Publicar Cupón";
            this.CreateBindings(this.buttonBuscar, this.limpiarButton, this.buttonPublicar, new Button(), this.cuponDataGrid);
        }

        protected override void CreateSpecificBindings()
        {
            this.cuponDataGrid.BindSourceTo(this.Data, "id_cupon", new Dictionary<string, string>
            {
                {"Proveedor", "descripcionProveedor"},
                {"Descripcion", "descripcion"},
                {"Precio Real", "precio_real"},
                {"Cantidad", "cant_disp"}
            });

            this.fecActual.Value = ControlBindingHelpers.FechaSistema;

            this.cargarProveedores();

            this.buttonCancelar.Click +=
                (sender, args) => this.Close();

            this.buttonPublicar.Click +=
                (sender, args) => this.Publicar(this.Filter);
        }

        private void Publicar(Cupon filter)
        {
            var cupon = this.home.GetCuponById(this.IdSeleccionado);
            this.home.Publicar(cupon);
            this.SuccessMessage("El cupón se publico correctamente",false);
            this.ExecSubmit();

        }

        private void cargarProveedores()
        {
            var proveedores = HomeFactory.Usuario.ListarProveedores(new Proveedor());
            var todos = new Proveedor {id_rol = 0, razon_social = "Todos"};
            proveedores.Insert(0,todos);
            this.comboBoxProveedor.BindSourceTo(proveedores, "id_usuario", "razon_social");
            

        }


        private string IdSeleccionado
        {
            get { return this.cuponDataGrid.GetSelectedItem<Cupon>().id_cupon.ToString(); }
        }

        protected override void  ExecSubmit()
        {
            this.Data = this.home.CuponesParaPublicar(fecActual.Value,(comboBoxProveedor.SelectedItem as Proveedor).id_usuario);
        }
        

    }
}
