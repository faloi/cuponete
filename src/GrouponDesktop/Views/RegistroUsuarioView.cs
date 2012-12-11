using System;
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
        private readonly UsuarioHome home;
        
        public RegistroUsuarioView(Usuario usuario)
        {
            InitializeComponent();

            this.home = HomeFactory.Usuario;
            this.SetBindingSource(usuario);

            this.Text = "Registro de Usuario";
            this.CreateBindings(this.guardarButton);
        }

        protected override void CreateSpecificBindings()
        {
            this.username.BindTextTo(this.model, "username");
            this.password.BindTextTo(this.model, "password");
            
            this.apellidoCliente.BindTextTo(this.model,"apellido");
            this.nombreCliente.BindTextTo(this.model, "nombre");
            this.dniCliente.BindTextTo(this.model, "dni", DataType.INTEGER);
            this.emailCliente.BindTextTo(this.model, "mail");
            this.telefonoCliente.BindTextTo(this.model, "telefono");
            this.calleCliente.BindTextTo(this.model, "direccionCalle");
            this.numeroDirCliente.BindTextTo(this.model, "direccionNumero");
            this.dptoDirCliente.BindTextTo(this.model, "direccionDto");
            this.localidadCliente.BindTextTo(this.model, "direccionLocalidad");
            this.cpostalCliente.BindTextTo(this.model, "cod_postal");
            //this.fechaNacCliente.BindTextToDate(this.model, "fecha_nac", "dd/MM/yyyy");

            //TODO: faltan los bindings del proveedor
            this.contactoProveedor.BindTextTo(this.model, "contacto_nombre");
            this.razonSocialProveedor.BindTextTo(this.model, "razon_social");

            this.limpiarButton.Click +=
                (sender, args) => this.model.DataSource = new Cliente();

            this.CargarRoles();
            this.CargarCiudadesPref();
            this.CargarRubros();
            this.CargarCiudadesProv();
        }

        protected override void ExecSubmit()
        {
            if (this.EsCliente)
                this.home.RegistrarCliente(this.model.DataSource as Cliente, this.ciuPrefClienteBox.GetCheckedItems<Ciudad>());
            else
                this.home.RegistrarProveedor(this.model.DataSource as Proveedor);
        }

        private void CargarRoles()
        {
            var roles = new Adapter().TransformMany<Rol>(HomeFactory.Rol.RolesDisponibles());
            this.comboRol.BindSourceTo(roles, "id_rol", "descripcion");

        }

        private void CargarRubros()
        {
            var rubros = new Adapter().TransformMany<Rubro>(HomeFactory.Rubro.RubrosDisponibles());
            this.comboRubro.BindSourceTo(rubros, "id_rubro", "desc_rubro");

        }

        private void CargarCiudadesProv()
        {
            var ciudades = new Adapter().TransformMany<Ciudad>(HomeFactory.Ciudad.CiudadesDisponibles());
            ciudadProvCombo.BindSourceTo(ciudades, "id_ciudad", "descripcion");
        }


        private void CargarCiudadesPref()
        {
            var ciudades = new Adapter().TransformMany<Ciudad>(HomeFactory.Ciudad.CiudadesDisponibles());
            ciuPrefClienteBox.BindSourceTo(ciudades, "id_ciudad", "descripcion");
        }

        private void ComboRolSelectedIndexChanged(object sender, EventArgs e)
        {
            this.proveedorGroupBox.Visible = !this.EsCliente;
            this.clienteGroupBox.Visible = this.EsCliente;

            if (this.EsCliente)
                this.SetBindingSource(new Cliente(this.model.DataSource as Usuario));
            else
                this.SetBindingSource(new Proveedor(this.model.DataSource as Usuario));
        }

        private bool EsCliente
        {
            get { return ((Rol) this.comboRol.SelectedItem).descripcion.Equals("Cliente"); }
        }

        protected override bool Validar()
        {
            var fieldsObligatorios = new List<TextBox>
               {
                   this.nombreCliente,
                   this.apellidoCliente,
                   this.dniCliente,
                   this.emailCliente,
                   this.calleCliente,
                   this.numeroDirCliente,
                   this.telefonoCliente,
                   this.username,
                   this.password,
                   this.repitaPassword
               };
            return (ValidatorHelper.ValidateObligatorio(fieldsObligatorios, this.errorProvider) && ValidatorHelper.ValidateCheckList(this.ciuPrefClienteBox, this.errorProvider));
        }
    }
}
