using System.Windows.Forms;

namespace GrouponDesktop.Helpers
{
    public static class MessageFactory
    {
        private static void ReadOnly(string template, object[] parameters, MessageBoxIcon icon)
        {
            MessageBox.Show(string.Format(template, parameters), string.Empty, MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1);
        }

        public static void Alert(string template, params object[] parameters)
        {
            ReadOnly(template, parameters, MessageBoxIcon.Exclamation);
        }

        public static void Error(string template, params object[] parameters)
        {
            ReadOnly(template, parameters, MessageBoxIcon.Hand);
        }

        public static void Info(string template, params object[] parameters)
        {
            ReadOnly(template, parameters, MessageBoxIcon.Information);
        }
    }
}
