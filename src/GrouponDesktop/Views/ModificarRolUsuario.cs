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
using GrouponDesktop.Sql;

namespace GrouponDesktop.Views
{
    public partial class ModificarRolUsuario : DefaultView
    {
        private readonly UsuarioHome home;

        public ModificarRolUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.tipoUsuarioDisponible = TODOS;
            this.home = HomeFactory.Usuario;
            this.SetBindingSource(usuario);

            this.Text = "Modificar Usuario";
            this.CreateBindings(this.guardarButton);
        }

        protected override void CreateSpecificBindings()
        {
            this.CargarRoles();
        }

        private void CargarRoles()
        {
            var roles = new Adapter().TransformMany<Rol>(HomeFactory.Rol.RolesDisponiblesHabilitados());
            this.comboBoxRol.BindSourceTo(roles, "id_rol", "descripcion");
            this.comboBoxRol.BindValueTo(this.model, "id_rol");
        }

        protected override void ExecSubmit()
        {
            var usuario = this.model.DataSource as Usuario;
            this.home.ModificarUsuario(usuario);
            SuccessMessage("El rol del usuario fue cambiado con éxito");
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
