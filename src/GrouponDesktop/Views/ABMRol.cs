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
    public partial class ABMRol : DefaultView
    {
        public ABMRol()
        {
            InitializeComponent();
        }

        private void buttonNuevoRol_Click(object sender, EventArgs e)
        {
            this.Redirect(new RegistroRolView());
        }
    }
}
