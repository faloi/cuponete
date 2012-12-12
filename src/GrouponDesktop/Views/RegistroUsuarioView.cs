﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Views
{
    public partial class RegistroUsuarioView : DefaultView
    {
        public RegistroUsuarioView()
        {
            this.InitializeComponent();

            this.proveedorButton.Click += (sender, args) => this.Redirect(new ModificarProveedor(null));
            this.clienteButton.Click += (sender, args) => this.Redirect(new ModificarCliente());
            this.Close();
        }
    }
}