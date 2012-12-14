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
    public partial class ABMUsuario : ListadoView<Cliente, UsuarioHome>
    {
        public ABMUsuario() : base(HomeFactory.Usuario) {}

        protected override void Setup()
        {
            this.InitializeComponent();
            this.tipoUsuarioDisponible = ADMINISTRADOR;
            this.Text = "Listado de Usuarios";
            this.CreateBindings(this.buttonBuscar, this.limpiarButton, this.buttonModificar, this.buttonBajaRestaurar, this.usuariosDataGrid);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxNombreDeUsuario.BindTextTo(this.Example, "username");

            this.usuariosDataGrid.BindSourceTo(this.Data, "id_usuario", new Dictionary<string, string>
            {
                {"Nombre de Usuario", "username"},
                {"Rol", "descripcion_rol"},
                {"Estado", "descripcion_estado"},
                {"Esta Bloqueado", "descripcion_bloqueado"}
            });


            this.buttonModificar.Click +=
                (sender, args) => this.ModificarUsuario();

            this.buttonBajaRestaurar.Click +=
                (sender, args) => this.BajaRestaurarUsuario();

            this.buttonDesbloquear.Click +=
                (sender, args) => this.DesbloquearUsuario();
        }

        private void DesbloquearUsuario()
        {
            var usuario = this.home.GetUsuarioById(this.IdSeleccionado);
            this.home.ReiniciarFallasDeUsuario(usuario);
            MessageBox.Show("El usuario se desbloqueó con éxito");

        }

        private void ModificarUsuario()
        {
            new VentanaRolPassword(this.home.GetUsuarioById(IdSeleccionado)).ShowDialog();
            this.ExecSubmit();
        }

        private void BajaRestaurarUsuario()
        {
            var usuario = this.home.GetUsuarioById(this.IdSeleccionado);
            if (usuario.estado == 0)
            {
                this.home.DarDeAltaUsuario(usuario);
                MessageBox.Show("El usuario se Habilito con éxito");
            }
            else
            {
                this.home.DarDeBajaUsuario(usuario);
                MessageBox.Show("El usuario se Deshabilito con éxito");
            }
            this.ExecSubmit();
        }


        private string IdSeleccionado
        {
            get { return this.usuariosDataGrid.GetSelectedItem<Usuario>().id_usuario.ToString(); }
        }

        protected override void ExecSubmit()
        {
            this.Data = this.home.ListarUsuarios(this.Filter);
        }
    }
}
