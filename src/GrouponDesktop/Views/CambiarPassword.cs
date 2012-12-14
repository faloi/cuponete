using System;
using System.Collections.Generic;
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
            this.SetBindingSource(HomeFactory.Usuario.UsuarioActual);
            this.Setup();
        }

        public CambiarPassword(Usuario usuario)
        {
            InitializeComponent();
            this.home = HomeFactory.Usuario;
            this.SetBindingSource(usuario);
            this.Setup();
        }

        private void Setup()
        {
            this.tipoUsuarioDisponible = TODOS;
            this.Text = "Cambiar Password";
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.CreateBindings(this.buttonCambiar);
        }

        protected override void ExecSubmit()
        {
            var usuario = this.model.DataSource as Usuario;
            usuario.password = this.textBoxPassword.Text;
            this.home.CambiaPassword(usuario);
            SuccessMessage("Password cambiado éxitosamente");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool Validar()
        {
            var fieldsObligatorios = new List<TextBox>
               {
                   this.textBoxPassword,
                
               };
            return (ValidatorHelper.ValidateObligatorio(fieldsObligatorios, this.errorProvider));

        }
    }
}
