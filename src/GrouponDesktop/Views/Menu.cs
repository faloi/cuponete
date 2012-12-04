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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        protected void Redirect(Form form)
        {
            form.Show();
        }

        private void administrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Redirect(new ABMProveedor());
        }

        private void administrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Redirect(new ABMCliente());
        }
    }
}
