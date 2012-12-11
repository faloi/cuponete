using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class ComprarGiftCard : DefaultView
    {
        private readonly UsuarioHome home;

        public ComprarGiftCard()
        {

            InitializeComponent();
            this.home = HomeFactory.Usuario;
            this.SetBindingSource(new Gift_card());
            this.rolDisponible = CLIENTE;

            this.Setup();
        }

        private void Setup()
        {
            this.Text = "Comprar Gift Card";
            this.CreateBindings(this.buttonComprar);
        }


        protected override void CreateSpecificBindings()
        {
            this.textBoxNomUsua.BindTextTo(this.model, "usuario_destino");
            this.CargarValoresGiftCard(); 
            this.buttonCancelar.Click +=
                (sender, args) => this.Close();
        }

        private void CargarValoresGiftCard()
        {
            List<string> valores = ConfigurationManager.AppSettings["valores"].Split(',').ToList<string>();
            var datasource = valores.Select(item => Convert.ToInt32(item)).ToList();
            this.comboBoxMontos.DataSource = datasource;
            

        }

         protected override void ExecSubmit()
         {
             this.fillData();
             this.home.ComprarGiftCard(this.model.DataSource as Gift_card);
             this.SuccessMessage("La compra se realizó exitosamente");

         }

         protected void fillData()
         {
             var gift = this.model.DataSource as Gift_card;
             gift.id_usuario_destino = this.home.GetClienteByUserName(gift.usuario_destino).id_usuario;
             gift.fecha = ControlBindingHelpers.GetFechaSistema();
             gift.monto = Convert.ToInt32(comboBoxMontos.SelectedValue);
             gift.id_usuario_origen = this.home.UsuarioActual.id_usuario;
         }

        protected override bool Validar()
        {
            var fieldsObligatorios = new List<TextBox>
               {
                   this.textBoxNomUsua,
                
               };
            return (ValidatorHelper.ValidateObligatorio(fieldsObligatorios, this.errorProvider) && ValidatorHelper.ValidateComboBox(this.comboBoxMontos, this.errorProvider));
      
        }

    }
}
