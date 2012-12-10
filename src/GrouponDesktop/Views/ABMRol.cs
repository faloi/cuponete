using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class ABMRol : ListadoView
    {
        private readonly RolHome home;

        public ABMRol()
        {
            InitializeComponent();
            this.home = HomeFactory.Rol;
            this.Example = new Rol();

            this.Setup();
        }

        private void Setup()
        {
            this.rolDisponible = ADMINISTRADOR;
            this.Text = "Listado de Roles";
            this.CreateBindings(this.buttonBuscar);
        }

        protected override void CreateSpecificBindings()
        {
            this.nombreRol.BindTextTo(this.Example, "descripcion");
  

            this.rolesDataGrid.BindSourceTo(this.Data, new Dictionary<string, string>
            {
                {"Nombre", "descripcion"}
            });

            this.buttonLimpiar.Click +=
                (sender, args) => this.Example = new Rol();
        }

        protected override void ExecSubmit()
        {
            this.Data = this.home.ListarRoles(this.Filter as Rol);
        }

        private void buttonNuevoRol_Click(object sender, EventArgs e)
        {
            this.Redirect(new RegistroRolView());
        }

        private void rolesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
           // if (e.RowIndex < 0 || e.ColumnIndex != rolesDataGrid.Columns["Rol"].Index) return;

            string descripcion = Convert.ToString(rolesDataGrid.Rows[e.RowIndex].Cells["Nombre"].Value);
        }





    }
}
