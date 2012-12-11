
using System;
using System.Drawing;
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
            this.textBoxFechaVto.BindTextTo(this.model, "fecha_vto_tarjeta");
            this.textBoxMonto.BindTextTo(this.model, "carga_credito", DataType.INTEGER);
            this.CargarFormaPago();
            this.comboBoxFormaPago.SelectedIndex = 1;
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
    }
}
