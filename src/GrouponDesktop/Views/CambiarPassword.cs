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
    public partial class CambiarPassword : DefaultView
    {
        private readonly UsuarioHome home;

        public CambiarPassword()
        {
            InitializeComponent();
            this.home = HomeFactory.Usuario;
            this.SetBindingSource(new Credito());
            this.Setup();
        }

        private void Setup()
        {
            this.rolDisponible = CLIENTE;
            this.Text = "Cambiar Password";
            this.CreateBindings(this.buttonCambiar);
        }
        
        protected override void CreateSpecificBindings()
        {
            //this.textBoxPassword.BindTextTo(this.model, "password");
        }

        

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
