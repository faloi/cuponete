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
    public partial class PublicarCupon : Form
    {
        public PublicarCupon()
        {
            InitializeComponent();

            this.Setup();
        }

        private void Setup()
        {
            this.cuponDataGrid.AllowUserToAddRows = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
