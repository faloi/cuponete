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
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            this.home.DarDeBajaUsuario(this.home.UsuarioActual);
            this.SuccessMessage("Su usuario fue dado de baja.");
            this.Close();
        }

    }
}
