using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class ABMRol : ListadoView<Rol, RolHome>
    {
        public ABMRol() : base(HomeFactory.Rol) {}

        protected override void Setup()
        {
            this.InitializeComponent();
            this.tipoUsuarioDisponible = ADMINISTRADOR;
            this.Text = "Listado de Roles";
            this.CreateBindings(this.buttonBuscar, this.buttonLimpiar, this.buttonModificar, this.buttonBajaRestaurar, this.rolesDataGrid);
        }

        protected override void CreateSpecificBindings()
        {
            this.nombreRol.BindTextTo(this.Example, "descripcion");

            this.rolesDataGrid.BindSourceTo(this.Data,"id_rol", new Dictionary<string, string>
            {
                {"Nombre", "descripcion"},
                {"Estado", "descripcionEstado"}
            });

            this.buttonModificar.Click +=
                (sender, args) => this.ModificarRol();

            this.buttonNuevoRol.Click +=
                (sender, args) => this.Redirect(new RegistroRolView());

            this.buttonBajaRestaurar.Click +=
                (sender, args) => this.BajaRestaurarRol();
        }

        private void BajaRestaurarRol()
        {
            var rol = this.home.GetRolById(this.IdSeleccionado);
            if (rol.estado == 0)
            {
                this.home.HabilitarRol(rol);
                MessageBox.Show("El rol se Habilito con éxito");
            }
            else
            {
                this.home.DeshabilitarRol(rol);
                MessageBox.Show("El rol se Deshabilito con éxito");
            }

            this.ExecSubmit();
        }

        protected override void ExecSubmit()
        {
            this.Data = this.home.ListarRoles(this.Filter);
        }

        private void ModificarRol()
        {
            var rol = this.home.GetRolById(this.IdSeleccionado);
            new RegistroRolView(rol).ShowDialog();

            this.ExecSubmit();
        }

        private string IdSeleccionado
        {
            get { return this.rolesDataGrid.GetSelectedItem<Rol>().id_rol.ToString(); }
        }

    }
}
