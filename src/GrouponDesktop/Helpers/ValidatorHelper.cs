using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.Helpers
{
    public static class ValidatorHelper
    {


        public static bool ValidateObligatorio(IEnumerable<TextBox> boxes, ErrorProvider errorProvider)
        {
            
            var ret = true;
            foreach (var textBox in boxes)
            {
                if (textBox.Text.Equals("") || textBox.Text.Equals("0"))
                {
                   // Set the error if the name is not valid.
                    errorProvider.SetError(textBox, "Este campo es obligatorio");
                    ret = false;
                }
                else
                {
                    // Clear the error, if any, in the error provider.
                    errorProvider.SetError(textBox, "");
                    
                }
                
            }
            return ret;

        }

        public static bool ValidateObligatorio(IEnumerable<RichTextBox> boxes, ErrorProvider errorProvider)
        {

            var ret = true;
            foreach (var textBox in boxes)
            {
                if (textBox.Text.Equals("") || textBox.Text.Equals("0"))
                {
                    // Set the error if the name is not valid.
                    errorProvider.SetError(textBox, "Este campo es obligatorio");
                    ret = false;
                }
                else
                {
                    // Clear the error, if any, in the error provider.
                    errorProvider.SetError(textBox, "");

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

        public static bool ValidateComboBox(ComboBox boxes, ErrorProvider errorProvider)
        {
            if (!boxes.SelectedIndex.Equals(-1))
                return true;
            errorProvider.SetError(boxes, "Este campo es obligatorio");
            return false;

        }

        public static bool ValidateFormatoVtoTarjeta(TextBox box,ErrorProvider errorProvider)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box.Text, "^((0[1-9])|(1[0-2]))/((2009)|(20[1-2][0-9]))$"))
                return true;
            else
            {
                errorProvider.SetError(box, "El formato de la fecha de vencimiento debe ser MM/yyyy");
                return false;
            };

        }

        public static bool ValidateMontoPositivo(TextBox textBoxMonto, ErrorProvider errorProvider)
        {
             if(Convert.ToDecimal(textBoxMonto.Text) <= 0)
             {
                 errorProvider.SetError(textBoxMonto, "El monto debe ser mayor a cero");
                 return false; 
             }
            return true;
        }

        public static bool ValidateMontoPositivo(List<TextBox> boxes, ErrorProvider errorProvider)
        {

            var ret = true;
            foreach (var textBox in boxes)
            {
                if (Convert.ToDecimal(textBox.Text) <= 0)
                {
                    // Set the error if the name is not valid.
                    errorProvider.SetError(textBox, "El campo debe ser mayor a cero");
                    ret = false;
                }
                else
                {
                    // Clear the error, if any, in the error provider.
                    errorProvider.SetError(textBox, "");

                }

            }
            return ret;
        }
    }
}
