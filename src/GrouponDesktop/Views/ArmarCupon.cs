using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.Views
{
    public partial class ArmarCupon : DefaultView
    {
        public ArmarCupon()
        {
            InitializeComponent();

            this.Setup();
        }

        private void Setup()
        {
            this.rolDisponible = PROVEEDOR;
            this.Text = "Armar Cupón";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
