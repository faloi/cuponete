using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class ComprarGiftCard : DefaultView
    {
        private readonly GiftCardHome home;

        public ComprarGiftCard()
        {
            InitializeComponent();
            this.home = HomeFactory.GiftCard;
            this.SetBindingSource(new Gift_card());

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
        }

        private void CargarValoresGiftCard()
        {
            List<string> valores = ConfigurationManager.AppSettings["valores"].Split(',').ToList<string>();
            var datasource = valores.Select(item => Convert.ToInt32(item)).ToList();
            this.comboBoxMontos.DataSource = datasource;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
