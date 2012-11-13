using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class LoginView : DefaultView
    {
        private readonly UsuarioHome home;
        private readonly Usuario model;

        public LoginView()
        {
            InitializeComponent();
            
            this.home = HomeFactory.Usuario;
            this.model = this.home.UsuarioActual;

            this.CreateBindings();
        }

        private void CreateBindings()
        {
            this.usernameTextBox.BindTextTo(this.model, "username");
            this.passwordTextBox.BindTextTo(this.model, "password");

            this.loginButton.Click +=
                (sender, args) => this.Submit();
        }

        protected override void ExecSubmit()
        {
            this.home.Login(this.model);
        }
    }
}
