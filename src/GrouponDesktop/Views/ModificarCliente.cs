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
    public partial class ModificarCliente : DefaultView
    {
        private readonly UsuarioHome home;

        public ModificarCliente(Cliente cliente)
        {
            InitializeComponent();

            this.home = HomeFactory.Usuario;
            this.SetBindingSource(cliente);

            this.Text = "Modificar Cliente";
            this.CreateBindings(this.guardarButton);
        }
        
        protected override void CreateSpecificBindings()
        {
            this.nombreCliente.BindTextTo(this.model, "nombre");
            this.apellidoCliente.BindTextTo(this.model, "apellido");
            this.dniCliente.BindTextTo(this.model, "dni", DataType.INTEGER);
            this.emailCliente.BindTextTo(this.model, "mail");
            this.telefonoCliente.BindTextTo(this.model, "telefono", DataType.INTEGER);
            this.cpostalCliente.BindTextTo(this.model, "cod_postal");
            this.direccionCliente.BindTextTo(this.model, "direccion");
            this.fechaNacCliente.BindTextToDate(this.model, "fecha_nac", "dd/MM/yyyy");

            //this.CargarCiudades();
        }

        private void CargarCiudades()
        {
            throw new NotImplementedException();
        }
    }
}
