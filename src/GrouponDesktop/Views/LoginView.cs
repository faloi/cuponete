using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class LoginView
    {
        private readonly UsuarioHome home;
        private readonly Usuario model;

        public LoginView()
        {
            InitializeComponent();

            this.home = HomeFactory.Usuario;
            this.model = this.home.UsuarioActual;

            this.Setup();
            this.CreateBindings(this.loginButton);
        }

        private void Setup()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            this.Text = "Bienvenido a Cuponete";
        }

        protected override void CreateSpecificBindings()
        {
            this.usernameTextBox.BindTextTo(this.model, "username");
            this.passwordTextBox.BindTextTo(this.model, "password");
            this.registrarButton.Click +=
                (sender, args) => this.Redirect(new RegistroUsuarioView());
        }

        protected void Redirect(Form form)
        {
            this.Hide();
            form.Show();
        }


        protected override void ExecSubmit()
        {
            this.home.Login(this.model);
            this.Redirect(new Menu());
        }

    }
}