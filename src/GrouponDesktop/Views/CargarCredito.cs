
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
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
            this.tipoUsuarioDisponible = CLIENTE;
            this.Text = "Cargar Credito";
            this.CreateBindings(this.buttonCargar);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxNroTarjeta.BindTextTo(this.model, "nro_tarjeta");
            this.textBoxCodDeSeg.BindTextTo(this.model, "cod_seguridad_tarjeta");
            this.textBoxFechaVto.BindTextTo(this.model, "fecha_vto_tarjeta");
            this.textBoxMonto.BindTextTo(this.model, "carga_credito", DataType.INTEGER);
            this.CargarFormaPago();
            this.buttonCancelar.Click +=
                (sender, args) => this.Close();
        }

        private void CargarFormaPago()
        {
            var roles = new Adapter().TransformMany<Forma_de_pago>(HomeFactory.FormaPago.FormaPagoDisponibles());
            this.comboBoxFormaPago.BindSourceTo(roles, "id_forma_pago", "descripcion");
            this.comboBoxFormaPago.SelectedIndex = 1;
        }

        protected override void ExecSubmit()
        {
            this.fillData();
            this.home.CargarCredito(this.model.DataSource as Credito);
            this.SuccessMessage("La compra se realizó exitosamente");
        }

        protected void fillData()
        {
            var credito = this.model.DataSource as Credito;
            credito.fecha = ControlBindingHelpers.GetFechaSistema();
            credito.id_forma_pago = Convert.ToInt32(comboBoxFormaPago.SelectedValue);
            credito.id_cliente = HomeFactory.Usuario.UsuarioActual.id_usuario;
            credito.fecha_vto_tarjeta = (textBoxFechaVto.Text ?? "");
            if(!pagaConTarjeta())
            {
                credito.nro_tarjeta = 0;
                credito.fecha_vto_tarjeta = "";
                credito.cod_seguridad_tarjeta = 0;
            } 
            
        }


        private void comboBoxFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {  
            this.Size = new Size(281, 438);
            if(Equals(this.comboBoxFormaPago.Text, "Efectivo"))
            {
                this.groupBox1.Visible = false;
                this.labelMonto.Location = new Point(12, 260 - 191);
                this.textBoxMonto.Location = new Point(16, 284 - 191);
                this.buttonCargar.Location = new Point(16, 318 - 191);
                this.buttonCancelar.Location = new Point(80, 369 - 191);
                this.Size = new Size(281, 438 - 191);
            }
            else
            {
                this.groupBox1.Visible = true;
                this.labelMonto.Location = new Point(12, 260);
                this.textBoxMonto.Location = new Point(16, 284);
                this.buttonCargar.Location = new Point(16, 318);
                this.buttonCancelar.Location = new Point(80, 369);
                this.Size = new Size(281, 438);
            }

        }

        protected bool pagaConTarjeta()
        {
            return ((this.comboBoxFormaPago.SelectedItem as Forma_de_pago).descripcion == "Crédito");
        }

        protected override bool Validar()
        {
            bool ret = true;
            var fieldsObligatorios = new List<TextBox>
               {this.textBoxMonto};
            if(pagaConTarjeta())
            {
                fieldsObligatorios.Add(this.textBoxCodDeSeg);
                fieldsObligatorios.Add(this.textBoxNroTarjeta);
                fieldsObligatorios.Add(this.textBoxFechaVto);
                ret = ValidatorHelper.ValidateFormatoVtoTarjeta(this.textBoxFechaVto, this.errorProvider);
            }
            return (ret && ValidatorHelper.ValidateObligatorio(fieldsObligatorios, this.errorProvider)
                && ValidatorHelper.ValidateComboBox(this.comboBoxFormaPago, this.errorProvider)
                && ValidatorHelper.ValidateMontoPositivo(this.textBoxMonto, this.errorProvider)
                );

        }

        private void textBoxNroTarjeta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
