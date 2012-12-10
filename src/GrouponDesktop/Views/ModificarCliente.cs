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
using GrouponDesktop.Sql;

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

            this.CargarCiudadesPref();
            this.FiltrarCiudades();
        }


        private void CargarCiudadesPref()
        {
            var ciudades = new Adapter().TransformMany<Ciudad>(HomeFactory.Ciudad.CiudadesDisponibles());
            ciuPrefClienteBox.BindSourceTo(ciudades, "id_ciudad", "descripcion");
        }


        private void FiltrarCiudades()
        {
            var funcionalidades = (HomeFactory.Ciudad.CiudadesPorCliente((this.model.DataSource as Cliente).id_usuario));
            var checkBoxItems = ciuPrefClienteBox.DataSource as List<Ciudad>;
            foreach (var checkBoxItem in checkBoxItems)
            {
                Ciudad ciudad = checkBoxItem as Ciudad;
                if (funcionalidades.Any(obj => obj.descripcion == ciudad.descripcion))
                    ciuPrefClienteBox.SetItemChecked(checkBoxItems.IndexOf(checkBoxItem), true);
            }
        }
    }
}
