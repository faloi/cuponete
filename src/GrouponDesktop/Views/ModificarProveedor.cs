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
    public partial class ModificarProveedor : DefaultView
    {
        private readonly UsuarioHome home;
            
        public ModificarProveedor(Proveedor proveedor)
        {
            InitializeComponent();

            this.home = HomeFactory.Usuario;
            this.SetBindingSource(proveedor);

            this.Text = "Modificar Proveedor";
            this.CreateBindings(this.guardarButton);
        }

        protected override void CreateSpecificBindings()
        {
            this.razonSocialProveedor.BindTextTo(this.model, "razon_social");
            this.emailProveedor.BindTextTo(this.model, "mail");
            this.telefonoProveedor.BindTextTo(this.model, "telefono", DataType.INTEGER);
            this.direccionProveedor.BindTextTo(this.model, "direccion");
            this.cPostalProveedor.BindTextTo(this.model, "cod_postal", DataType.INTEGER);
            this.cuitProveedor.BindTextTo(this.model, "cuit");
            this.contactoProveedor.BindTextTo(this.model, "contacto_nombre");
            this.comboRubro.BindTextTo(this.model, "id_rubro");

            //this.CargarCiudades();
        }
    }
}
