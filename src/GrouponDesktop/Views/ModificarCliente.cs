using System.Collections.Generic;
using System.Linq;
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
        private IEnumerable<Ciudad> ciudadesOriginales;

        private bool IsNew { get; set; }

        public ModificarCliente() : this(new Cliente(), true) {}

        public ModificarCliente(Cliente cliente) : this(cliente, false) {}

        public ModificarCliente(Cliente cliente, bool isNew)
        {
            InitializeComponent();

            this.IsNew = isNew;
            this.usuarioGroupBox.Visible = this.limpiarButton.Visible = this.direccionGroupBox.Visible = this.IsNew;

            this.home = HomeFactory.Usuario;
            this.SetBindingSource(cliente);

            this.Text = "Modificar Cliente";
            this.CreateBindings(this.guardarButton);
            this.password.UseSystemPasswordChar = true;
        }
        
        protected override void CreateSpecificBindings()
        {
            this.nombreCliente.BindTextTo(this.model, "nombre");
            this.apellidoCliente.BindTextTo(this.model, "apellido");
            this.dniCliente.BindTextTo(this.model, "dni", DataType.INTEGER);
            this.emailCliente.BindTextTo(this.model, "mail");
            this.telefonoCliente.BindTextTo(this.model, "telefono", DataType.INTEGER);
            this.cpostalCliente.BindTextTo(this.model, "cod_postal");
            this.fechaNacCliente.BindTextToDate(this.model, "fecha_nac", "dd/MM/yyyy");

            if (this.IsNew)
            {
                this.username.BindTextTo(this.model, "username");
                this.password.BindTextTo(this.model, "password");
                this.calle.BindTextTo(this.model, "direccionCalle");
                this.numero.BindTextTo(this.model, "direccionNumero");
                this.piso.BindTextTo(this.model, "direccionPiso");
                this.depto.BindTextTo(this.model, "direccionDto");
                this.localidad.BindTextTo(this.model, "direccionLocalidad");
            }
            else
            {
                this.direccionCliente.BindTextTo(this.model, "direccion");
            }

            this.CargarCiudadesPref();

            if (!this.IsNew)
                this.SeleccionarCiudades();
        }

        protected override void ExecSubmit()
        {
            var cliente = this.model.DataSource as Cliente;
            var ciudadesSeleccionadas = this.ciuPrefClienteBox.GetCheckedItems<Ciudad>();

            if (this.IsNew)
                this.home.RegistrarCliente(cliente, ciudadesSeleccionadas);
            else
            {
                var ciudadesEliminadas = this.ciudadesOriginales.Except(ciudadesSeleccionadas);
                var ciudadesAgregadas = ciudadesSeleccionadas.Except(this.ciudadesOriginales);
                this.home.ModificarCliente(cliente, ciudadesAgregadas, ciudadesEliminadas);
            }
            this.Close();
        }

        protected override bool Validar()
        {
            var fieldsObligatorios = new List<TextBox>
            {
               this.nombreCliente,
               this.apellidoCliente,
               this.dniCliente,
               this.emailCliente,
               this.telefonoCliente               
            };

            if (this.IsNew)
                fieldsObligatorios.AddRange(new[] { this.username, this.password });

            return (ValidatorHelper.ValidateObligatorio(fieldsObligatorios, this.errorProvider) && ValidatorHelper.ValidateCheckList(this.ciuPrefClienteBox, this.errorProvider));
        }

        private void CargarCiudadesPref()
        {
            var ciudades = new Adapter().TransformMany<Ciudad>(HomeFactory.Ciudad.CiudadesDisponibles());
            ciuPrefClienteBox.BindSourceTo(ciudades, "id_ciudad", "descripcion");
        }

        private void SeleccionarCiudades()
        {
            var cliente = this.model.DataSource as Cliente;
            this.ciudadesOriginales = HomeFactory.Ciudad.CiudadesPorCliente(cliente.id_usuario);

            var todasLasCiudades = ciuPrefClienteBox.DataSource as List<Ciudad>;

            foreach (var ciudad in todasLasCiudades.Where(ciudad => ciudadesOriginales.Contains(ciudad, new CiudadEqualityComparer())))
                ciuPrefClienteBox.SetItemChecked(todasLasCiudades.IndexOf(ciudad), true);
        }
    }
}
