using System;
using System.Windows.Forms;

namespace GrouponDesktop.Helpers
{
    public static class FormCreator
    {
        public static void Show(string formName)
        {
            try
            {
                var form = Activator.CreateInstance("GrouponDesktop", "GrouponDesktop.Views." + formName).Unwrap() as Form;
                form.ShowDialog();
            }
            catch (TypeLoadException)
            {
                MessageFactory.Error("No se encontró el formulario {0}", formName);
            }
        }
    }
}