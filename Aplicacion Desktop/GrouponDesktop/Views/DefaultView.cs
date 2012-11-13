using System;
using System.Windows.Forms;

namespace GrouponDesktop.Views
{
    public abstract class DefaultView : Form
    {
        protected void Submit()
        {
            try
            {
               this.ExecSubmit();
            }
            catch (ApplicationException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        protected abstract void ExecSubmit();
    }
}
