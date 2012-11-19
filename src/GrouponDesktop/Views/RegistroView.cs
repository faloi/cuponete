using System;
using System.Collections;
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
    public partial class RegistroView : Form
    {
        private readonly UsuarioHome usuarioHome;
        private readonly RolHome rolHome;
        private readonly Usuario model;

        public RegistroView()
        {
            InitializeComponent();

            this.usuarioHome = HomeFactory.Usuario;
            this.model = this.home.UsuarioActual;

            this.Setup();
            this.CreateBindings(this.guardarButton);
        }
        private void Setup()
        {
            this.Text = "Registro de Usuario";
        }

        protected void CreateSpecificBindings()
        {
            this.username.BindTextTo(this.model,"username");
            this.password.BindTextTo(this.model,"password");
            this.CargarRoles(); 
        }

        private void CargarRoles()
        {
            ArrayList roles = Query.getRubros();
            comboRol.DisplayMember = "descripcion";
            comboRol.ValueMember = "id_rol";
            comboRol.Items.AddRange(roles.ToArray());

        
        }

        protected override void ExecSubmit()
        {
            this.home.Login(this.model);
            this.Redirect(new HomeView());
        }

    }
}
