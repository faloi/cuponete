using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FacturarProveedor : ListadoView<ProveedorFacturacion>
    {
        private readonly CuponHome home;

        public FacturarProveedor()
        {
            this.InitializeComponent();
            this.home = HomeFactory.Cupon;
            this.CreateBindings(this.buttonBuscar, this.limpiarButton, this.buttonFacturar, new Button(), this.cuponesDataGrid);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxProveedor.BindTextTo(this.Example, "id_proveedor");
            this.dateTimePickerDesde.BindTextTo(this.Example, "fecha_inicio");

            this.cuponesDataGrid.BindSourceTo(this.Data, new Dictionary<string, string>
            {
                {"Código compra", "codigo_compra"},    
                {"Fecha de canje", "fecha_canje"},
                {"Precio", "precio_real"}
            });

            this.buttonCancelar.Click +=
                (sender, args) => this.Close();

            this.buttonFacturar.Click +=
                (sender, args) => this.home.Facturar(this.Filter);
        }

        protected override void ExecSubmit()
        {
            this.Data = this.home.CuponesParaFacturar(this.Filter);
        }
    }
}
