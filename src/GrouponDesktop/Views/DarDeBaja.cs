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
    public partial class DarDeBaja : DefaultView
    {
        private readonly UsuarioHome home;

        public DarDeBaja()
        {
            InitializeComponent();
            this.home = HomeFactory.Usuario;
            this.Setup();
        }

        private void Setup()
        {
            this.tipoUsuarioDisponible = TODOS;
            this.groupBoxDarDeBaja.Visible = false;
            this.groupBoxHabilitarDeshabilitar.Visible = true;    
            this.Text = "Habilitación Usuario";
            if (this.home.UsuarioActual.id_rol != 1)
                this.Redraw();
        }

        private void Redraw()
        {
            this.groupBoxDarDeBaja.Visible = true;
            this.groupBoxHabilitarDeshabilitar.Visible = false;
            this.Size = new Size(256, 197);
            this.Text = "Dar De Baja";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancelar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            this.home.DarDeBajaUsuario(this.home.UsuarioActual);
            this.SuccessMessage("Su usuario fue dado de baja.");
            this.Close();
        }

        private void buttonConfirmarAdmin_Click(object sender, EventArgs e)
        {
            if (Equals(this.comboBoxAccion.Text, "Deshabilitar"))
            {
                this.home.DarDeBajaUsuario(this.home.GetClienteByUserName(this.textBoxUsername.Text));
                this.SuccessMessage("El usuario " + this.textBoxUsername.Text + " fue deshabilitado.");
            }    
            else
            {
                this.home.DarDeAltaUsuario(this.home.GetClienteByUserName(this.textBoxUsername.Text));
                this.SuccessMessage("El usuario " + this.textBoxUsername.Text + " fue habilitado.");               
            }
        }


    }
}
