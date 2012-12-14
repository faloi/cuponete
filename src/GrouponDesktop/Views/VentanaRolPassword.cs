using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class VentanaRolPassword : DefaultView
    {

        private readonly UsuarioHome home;

        public VentanaRolPassword(Usuario usuario)
        {
            this.InitializeComponent();
            this.home = HomeFactory.Usuario;

            this.buttonPassword.Click += (sender, args) => this.CambiarPasswordUsuario(usuario);
            this.buttonRol.Click += (sender, args) => this.ModificarRolUsuario(usuario);
        }

        private void CambiarPasswordUsuario(Usuario usuario)
        {
            new CambiarPassword(usuario).ShowDialog();
        }

        private void ModificarRolUsuario(Usuario usuario)
        {
            new ModificarRolUsuario(usuario).ShowDialog();
        }
    }
}
