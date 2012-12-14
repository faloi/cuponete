using System;
using System.Windows.Forms;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public class DefaultView : Form
    {
        protected readonly int TODOS = 0;
        protected readonly int ADMINISTRADOR = 1;
        protected readonly int CLIENTE = 2;
        protected readonly int PROVEEDOR = 3;
        protected readonly BindingSource model;
        protected int tipoUsuarioDisponible;
        protected ErrorProvider errorProvider = new ErrorProvider {BlinkStyle = ErrorBlinkStyle.NeverBlink};
        

        protected DefaultView()
        {
            this.model = new BindingSource();
        }

        protected void CreateBindings(Button submitButton)
        {
            submitButton.Click +=
                (sender, args) => this.Submit();

            this.KeyPreview = true;
            this.KeyDown += (sender, args) => { if (args.KeyCode == Keys.Escape) this.Close(); };

            this.AcceptButton = submitButton;

            this.CreateSpecificBindings();
        }

        protected virtual void CreateSpecificBindings() {}

        protected void Submit()
        {
            try
            {
                ValidarRolActual();
                if(this.Validar())
                    this.ExecSubmit();
            }
            catch (ApplicationException e)
            {
                MessageFactory.Alert(e.Message);
            }
        }

        protected void ValidarRolActual()
        {
            if(this.tipoUsuarioDisponible != TODOS)
            {
                if (HomeFactory.Usuario.UsuarioActual.id_tipo_usuario != this.tipoUsuarioDisponible)
                {
                    MensajeRolNoPermitido();
                } 
            }

        }

        protected virtual bool Validar()
        {
            return true;
        }
        

        protected void Redirect(Form form)
        {
            form.Show();
        }

        protected void Redirect(Form form, bool closewindow)
        {
            form.ShowDialog();
            if(closewindow)
                this.Close();
        }

        protected virtual void ExecSubmit() {}

        protected void SetBindingSource(object source)
        {
            this.model.DataSource = source;
        }

        protected void MensajeRolNoPermitido()
        {
            throw new ApplicationException("El tipo de usuario actual no puede acceder a esta funcionalidad"); 
        }

        protected void SuccessMessage(string message)
        {
            MessageBox.Show(message);
            this.Close();
        }
        protected void SuccessMessage(string message,bool closewindow)
        {
            MessageBox.Show(message);
            if(closewindow)
                this.Close();
        }
    }
}