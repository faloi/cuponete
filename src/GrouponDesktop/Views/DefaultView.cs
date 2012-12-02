using System;
using System.Windows.Forms;
using GrouponDesktop.Helpers;

namespace GrouponDesktop.Views
{
    public class DefaultView : Form
    {
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
                this.ExecSubmit();
            }
            catch (ApplicationException e)
            {
                MessageFactory.Alert(e.Message);
            }
        }

        protected void Redirect(Form form)
        {
            this.Hide();
            form.Show();
        }

        protected virtual void ExecSubmit() {}
    }
}