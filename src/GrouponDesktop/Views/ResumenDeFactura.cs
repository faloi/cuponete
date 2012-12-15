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

namespace GrouponDesktop.Views
{
    public partial class ResumenDeFactura : DefaultView
    {
        public ResumenDeFactura(Factura factura)
        {
            this.InitializeComponent();
            this.CreateBindings(this.buttonAceptar);

            this.SetBindingSource(factura);
        }

        protected override void CreateSpecificBindings()
        {
            this.numeroFactura.BindTextTo(this.model, "nro_factura");
            this.montoTotal.BindTextTo(this.model, "monto_total");
        }

        protected override void ExecSubmit()
        {
            this.Close();
        }
    }
}
