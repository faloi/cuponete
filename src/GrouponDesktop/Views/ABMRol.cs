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
  

            this.rolesDataGrid.BindSourceTo(this.Data,"id_rol", new Dictionary<string, string>
            {
                {"Nombre", "descripcion"}
            });

            this.buttonLimpiar.Click +=
                (sender, args) => this.Example = new Rol();

            this.buttonModificar.Click +=
                (sender, args) => this.ModificarRol();
        }

        protected override void ExecSubmit()
        {
            this.Data = this.home.ListarRoles(this.Filter as Rol);
        }

        private void buttonNuevoRol_Click(object sender, EventArgs e)
        {
            this.Redirect(new RegistroRolView());
        }

        private void ModificarRol()
        {
            var rol = this.home.GetRolById(this.IdSeleccionado);
            new RegistroRolView(rol).ShowDialog();

            this.ExecSubmit();
        }

        private string IdSeleccionado
        {
            get { return Convert.ToString((this.rolesDataGrid.GetValue() as Rol).id_rol); }
        }

    }
}
