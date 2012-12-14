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
    public partial class ListadoEstadistico : ListadoView<Estadistica, EstadisticasHome>
    {
        public ListadoEstadistico() : base(HomeFactory.Estadisticas) {}

        protected override void Setup()
        {
            this.InitializeComponent();
            this.Text = "Listado Estadistico";
            
            this.CreateBindings(this.buttonConsultar,  this.dataGridView);
        }
        
        protected override void CreateSpecificBindings()
        {
            var semestres = new Dictionary<int, string>
            {
                {1, "Primero"},
                {2, "Segundo"}
            };

            this.comboBoxSemestre.BindSourceTo(semestres);
            
            var tiposListado = new Dictionary<TipoListado, string>
            {
                {TipoListado.AcreditacionGiftCards, "Acreditación de Giftcards por Usuario"},
                {TipoListado.PorcentajeDevolucionCompras, "Porcentaje de Devolución de Cupones por proveedor"}
            };

            this.comboBoxTipoListado.BindSourceTo(tiposListado);

            this.textBoxAno.BindTextTo(this.Example, "Anio", DataType.INTEGER);
            this.comboBoxSemestre.BindValueTo(this.Example, "Semestre");
            this.comboBoxTipoListado.BindValueTo(this.Example, "TipoListado");
        }

        protected override void ExecSubmit()
        {
            if (this.Filter.TipoListado == TipoListado.PorcentajeDevolucionCompras)
            {
                var columns = new Dictionary<string, string>
                 {
                     {"Razón social", "razon_social"}, 
                     {"Teléfono", "telefono"}, 
                     {"Porcentaje devolución", "porcentaje_devolucion"},
                 };

                var newData = this.home.PorcentajeDevolucionCompras(this.Filter);

                this.ChangeData(newData, columns);
            }
            else
            {
                var columns = new Dictionary<string, string>
                {
                  {"Teléfono", "telefono"},
                  {"Cantidad GiftCards", "cantidad_gc"},
                  {"Monto", "monto_total"}
                };

                var newData = this.home.AcreditacionGiftCards(this.Filter);

                this.ChangeData(newData, columns);
            }
        }

        protected override bool Validar()
        {
            var fieldsObligatorios = new List<TextBox> { this.textBoxAno };
            return (ValidatorHelper.ValidateObligatorio(fieldsObligatorios, this.errorProvider));
        }

        private void ChangeData(object newData, Dictionary<string, string> columns)
        {
            this.dataGridView.BindSourceTo(this.Data, columns);
            this.Data = newData;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
