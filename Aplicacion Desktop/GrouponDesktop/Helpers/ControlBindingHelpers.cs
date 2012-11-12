using System;
using System.Windows.Forms;

namespace GrouponDesktop.Helpers
{
    public static class ControlBindingHelpers
    {
        public static void BindTextTo(this Control control, object model, string propertyName)
        {
            control.DataBindings.Add("Text", model, propertyName);
        }

        public static void BindTextToDate(this Control control, object model, string propertyName, string format)
        {
            var binding = new Binding("Text", model, propertyName);
            binding.Format += (sender, args) => args.Value = ((DateTime)args.Value).ToString(format);

            control.DataBindings.Add(binding);
        }
    }
}

