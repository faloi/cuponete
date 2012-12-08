using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.Helpers
{
    public static class ValidatorHelper
    {


        public static bool ValidateObligatorio(List<TextBox> boxes, ErrorProvider errorProvider)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            var ret = true;
            foreach (var textBox in boxes)
            {
                if (!textBox.Text.Equals(""))
                {
                    // Clear the error, if any, in the error provider.
                    errorProvider.SetError(textBox, "");
                }
                else
                {
                    // Set the error if the name is not valid.
                    errorProvider.SetError(textBox, "Este campo es obligatorio");
                    ret = false;
                }
                
            }
            return ret;

        }

        public static bool ValidateCheckList(CheckedListBox boxes, ErrorProvider errorProvider)
        {
            if(boxes.CheckedItems.Count > 0)
                return true;
            errorProvider.SetError(boxes, "Este campo es obligatorio");
            return false;
 

            
        }

    }
}
