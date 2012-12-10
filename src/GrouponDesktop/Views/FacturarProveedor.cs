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
    public partial class FacturarProveedor : Form
    {
        public FacturarProveedor()
        {
            InitializeComponent();

            this.Setup();
        }

        private void Setup()
        {
            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
