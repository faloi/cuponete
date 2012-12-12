using System;
using System.Collections.Generic;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class ComprarCupon : ListadoView<Cupon>
    {
        private readonly CuponHome home;
        
        public ComprarCupon()
        {
            this.InitializeComponent();
            this.home = HomeFactory.Cupon;
            this.Setup();
        }

        private void Setup()
        {
            this.Text = "Comprar Cupón";
            this.CreateBindings(this.buttonComprarCupon);
            this.listaCupones();
        }

        private void listaCupones()
        {
            this.Data = this.home.CuponesDisponibles();
        }

        protected override void CreateSpecificBindings()
        {
            this.cuponDataGrid.BindSourceTo(this.Data, new Dictionary<string, string>
            {
                {"Descripcion", "descripcion"},
                {"Precio Ficticio", "precio_ficticio"},
                {"Precio Real", "precio_real"}
           });
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
