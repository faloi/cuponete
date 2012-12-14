using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class PopUpCuponComprado : DefaultView
    {
        public PopUpCuponComprado(Cupon_comprado cupon)
        {
            InitializeComponent();

            this.SetBindingSource(cupon);

            this.CreateBindings(this.buttonAceptar);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxNumero.BindTextTo(this.model, "codigo_compra");
        }

        protected override void ExecSubmit()
        {
            this.Close();
        }


    }
}
