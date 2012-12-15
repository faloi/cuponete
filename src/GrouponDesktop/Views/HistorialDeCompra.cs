using System.Collections.Generic;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class HistorialDeCompra : ListadoView<Cupon_comprado, CuponHome>
    {
        public HistorialDeCompra() : base(HomeFactory.Cupon) {}

        protected override void Setup()
        {
            this.InitializeComponent();
            this.tipoUsuarioDisponible = CLIENTE;
            this.CreateBindings(buttonBuscar, cuponesDataGrid);
        }

        protected override void CreateSpecificBindings()
        {
            this.dateTimePickerDesde.BindTextTo(this.Example, "FechaDesde");
            this.dateTimePickerHasta.BindTextTo(this.Example, "FechaHasta");

            this.cuponesDataGrid.BindSourceTo(this.Data, new Dictionary<string, string>
            {
                {"Fecha", "fecha_compra"}, 
                {"Fecha Vencimiento Consumo", "fec_venc_consumo"},
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
