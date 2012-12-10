
using System;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Views
{
    public partial class CargarCredito : DefaultView
    {
        private readonly UsuarioHome home;
        
        public CargarCredito()
        {
            InitializeComponent();
            this.home = HomeFactory.Usuario;
            this.SetBindingSource(new Credito());
            this.Setup();
            
        }

        private void Setup()
        {
            this.rolDisponible = CLIENTE;
            this.Text = "Cargar Credito";
            this.CreateBindings(this.buttonCargar);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxNroTarjeta.BindTextTo(this.model, "nro_tarjeta");
            this.textBoxCodDeSeg.BindTextTo(this.model, "cod_seguridad_tarjeta");
            //this.labelFechaVto.BindTextTo(this.model, "fecha_vto_tarjeta","dd/MM/yyyy");
            this.textBoxMonto.BindTextTo(this.model, "carga_credito", DataType.INTEGER);
            this.CargarFormaPago();
       }

        private void CargarFormaPago()
        {
            var roles = new Adapter().TransformMany<Forma_de_pago>(HomeFactory.FormaPago.FormaPagoDisponibles());
            this.comboBoxFormaPago.BindSourceTo(roles, "id_forma_pago", "descripcion");
        }


        private void buttonCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
