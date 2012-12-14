using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
     public partial class RegistroConsumo : DefaultView
    {

        private readonly CuponHome home;

        public RegistroConsumo()
        {
            InitializeComponent();
            this.home = HomeFactory.Cupon;
            this.SetBindingSource(new Cupon_canjeado());
            this.tipoUsuarioDisponible = PROVEEDOR;

            this.Text = "Registrar Consumo de Cupón";
            this.CreateBindings(this.buttonRegistrar);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxNroCupon.BindTextTo(this.model, "codigo_compra");
        }

        protected override void ExecSubmit()
        {
            var cupon_canjeado = this.model.DataSource as Cupon_canjeado;
            cupon_canjeado.id_proveedor = HomeFactory.Usuario.UsuarioActual.id_usuario;
            cupon_canjeado.fecha_canje = ControlBindingHelpers.GetFechaSistema();
            home.RegistrarConsumo(cupon_canjeado);
            this.SuccessMessage("El canje se registró correctamente");
        }

        protected override bool Validar()
        {
            var fieldsObligatorios = new List<TextBox>
               {
                   this.textBoxNroCupon,    
               };
            return (ValidatorHelper.ValidateObligatorio(fieldsObligatorios, this.errorProvider));
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
