using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Helpers;

namespace GrouponDesktop.Views
{
    public partial class Menu : DefaultView
    {
        public Menu()
        {
            InitializeComponent();
                this.menuStrip1.AddItem("hola", (sender, args) => FormCreator.Show("pepe"));
        }


        private void administrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProveedor form = new ABMProveedor();
            form.Show();
            form.Focus();
           // this.Redirect(new ABMProveedor());
        }

        private void administrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Redirect(new ABMCliente());
        }

        private void administrarRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Redirect(new ABMRol());
        }

        private void comprarCupónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Redirect(new ComprarCupon());
        }

        private void cargarCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Redirect(new CargarCredito());
        }
    }
}
