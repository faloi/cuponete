using System.Collections.Generic;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class HistorialDeCompra : ListadoView<Cupon_comprado>
    {
        private readonly CuponHome home;

        public HistorialDeCompra()
        {
            this.InitializeComponent();
            this.home = HomeFactory.Cupon;
            this.CreateBindings(buttonBuscar, cuponesDataGrid);
        }

        protected override void CreateSpecificBindings()
        {
            this.dateTimePickerDesde.BindTextTo(this.Example, "FechaDesde");
            this.dateTimePickerHasta.BindTextTo(this.Example, "FechaHasta");

            this.cuponesDataGrid.BindSourceTo(this.Data, new Dictionary<string, string>
            {
                {"Fecha", "fecha_compra"},    
                {"Descripción", "descripcion"},
                {"Código compra", "codigo_compra"},
                {"Precio", "precio_real"},
                {"Estado", "estado"}
            });

            this.buttonCancelar.Click +=
                (sender, args) => this.Close();
        }

        protected override void ExecSubmit()
        {
            this.Data = this.home.CuponesComprados(this.Filter);
        }
    }
}
