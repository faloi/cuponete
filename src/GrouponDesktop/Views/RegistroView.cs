using System;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Views
{
    public partial class RegistroView : DefaultView
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
            this.cliente = new Cliente();

            this.Setup();
        }

        private void Setup()
        {
            this.Text = "Registro de Usuario";
            this.CreateBindings(this.guardarButton);
        }

        protected override void CreateSpecificBindings()
        {
            this.username.BindTextTo(this.cliente, "username");
            this.password.BindTextTo(this.cliente, "password");
            this.comboRol.BindTextTo(this.cliente,"id_rol");
            this.apellidoCliente.BindTextTo(this.cliente,"apellido");
            this.nombreCliente.BindTextTo(this.cliente, "nombre");
            this.dniCliente.BindTextTo(this.cliente,"dni");
            this.emailCliente.BindTextTo(this.cliente, "mail");
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

        protected override void ExecSubmit()
        {
            throw new NotImplementedException();
        }

        private void CargarRoles()
        {
            var roles = new Adapter().TransformMany<Rol>(HomeFactory.Rol.RolesDisponibles());
            this.comboRol.BindSourceTo(roles, "id_rol", "descripcion");
        }

        private void CargarCiudades()
        {
            var ciudades = new Adapter().TransformMany<Ciudad>(HomeFactory.Ciudad.CiudadesDisponibles());
            ciuPrefClienteBox.BindSourceTo(ciudades, "id_ciudad", "descripcion");
        }

        private void ComboRolSelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox) sender;
            var rolSeleccionado = (Rol) comboBox.SelectedItem;
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
