using System;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Repositories;

namespace GrouponDesktop.ManagementUsuario
{
    public partial class LoginView : DefaultView
    {
        private readonly UserRepository repository;
        private readonly Usuario model;

        public LoginView()
        {
            InitializeComponent();
            
            this.repository = RepoFactory.User;
            this.model = new Usuario();

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
            this.repository.Login(this.model);
        }
    }
}
