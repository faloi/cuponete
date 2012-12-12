using System;
using GrouponDesktop.DTOs;
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
            this.SetBindingSource(new Usuario());
            this.Setup();
        }

        private void Setup()
        {
            this.rolDisponible = TODOS;
            this.Text = "Cambiar Password";
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.CreateBindings(this.buttonCambiar);
        }
        
        protected override void ExecSubmit()
        {
            this.home.CambiaPassword(this.textBoxPassword.Text);
            SuccessMessage("Su Password fue cambiado con éxito");
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
