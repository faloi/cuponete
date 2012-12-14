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
            this.Redirect(new CambiarPassword(usuario),true);
            
        }

        private void ModificarRolUsuario(Usuario usuario)
        {
            this.Redirect(new ModificarRolUsuario(usuario),true);
        }
    }
}
