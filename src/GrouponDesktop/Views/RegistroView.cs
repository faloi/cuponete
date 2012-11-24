using System;
using System.Collections;
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
    public partial class RegistroView : Form
    {
        private readonly UsuarioHome home;
        private readonly Usuario model;
        private readonly Cliente cliente;
        private readonly Proveedor proveedor;

        public RegistroView()
        {
            InitializeComponent();

            this.home = HomeFactory.Usuario;
            this.model = this.home.UsuarioActual;

            this.Setup();
        }

        private void Setup()
        {
            this.Text = "Registro de Usuario";
            this.CargarRoles();
        }

        protected void CreateSpecificBindings()
        {
            this.username.BindTextTo(this.cliente, "username");
            this.password.BindTextTo(this.cliente, "password");
            this.comboRol.BindTextTo(this.cliente,"id_rol");
            this.apellidoCliente.BindTextTo(this.cliente,"apellido");
            this.nombreCliente.BindTextTo(this.cliente, "nombre");
            this.dniCliente.BindTextTo(this.cliente,"dni");
            this.emailCliente.BindTextTo(this.cliente, "email");
            this.telefonoCliente.BindTextTo(this.cliente, "telefono");
            this.calleCliente.BindTextTo(this.cliente, "direccionCalle");
            this.numeroDirCliente.BindTextTo(this.cliente, "direccionNumero");
            this.dptoDirCliente.BindTextTo(this.cliente, "direccionDto");
            this.localidadCliente.BindTextTo(this.cliente, "direccionLocalidad");
            this.cpostalCliente.BindTextTo(this.cliente, "cod_postal");
            this.fechaNacCliente.BindTextToDate(this.cliente, "fecha_nac", "dd/MM/yyyy");
            this.CargarRoles(); 
            this.CargarCiudades();
        }

        private void CargarRoles()
        {
            IList<Rol>  roles = new Adapter().TransformMany<Rol>(HomeFactory.Rol.RolesDisponibles());
            this.comboRol.DataSource = roles;
    
            comboRol.DisplayMember = "descripcion";
            comboRol.ValueMember = "id_rol";
        

        }

        private void CargarCiudades()
        {
            IList<Ciudad> ciudades = new Adapter().TransformMany<Ciudad>(HomeFactory.Ciudad.CiudadesDisponibles());



        }

        private void ComboRolSelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox) sender;
            Rol rolSeleccionado = (Rol) comboBox.SelectedItem;
            if (rolSeleccionado.descripcion.Equals("Cliente"))
            {
                this.proveedorGroupBox.Visible = false;
                this.clienteGroupBox.Visible = true;
            }
            else
            {
                this.proveedorGroupBox.Visible = true;
                this.clienteGroupBox.Visible = false;   
            }
                
        }

    }
}
