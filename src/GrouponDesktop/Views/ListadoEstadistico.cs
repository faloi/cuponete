using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.Views
{
    public partial class ListadoEstadistico : DefaultView
    {
        public ListadoEstadistico()
        {
            InitializeComponent();

            this.Setup();
        }

        private void Setup()
        {
            this.Text = "Listado Estadistico";
            this.CreateBindings(this.buttonConsultar);
            this.dataGridViewCuponesDevueltos.AllowUserToAddRows = false;
            this.dataGridViewGifcardAcreditadas.AllowUserToAddRows = false;
        }
        
        protected override void CreateSpecificBindings()
        {
            this.CargarSemestres();
            this.CargarTiposDeListado();
        }

        private void CargarTiposDeListado()
        {
            var tiposDeListado = new List<string>
                                     {"Porcentaje de Devolución de Cupones", "Acreditación de Giftcards por Usuario"};
            this.comboBoxTipoListado.DataSource = tiposDeListado;
        }

        private void CargarSemestres()
        {
            var semestres = new List<int> {1, 2};
            this.comboBoxSemestre.DataSource = semestres;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTipoListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Equals(this.comboBoxTipoListado.Text, "Porcentaje de Devolución de Cupones"))
            {
                this.dataGridViewCuponesDevueltos.Visible = true;
                this.dataGridViewGifcardAcreditadas.Visible = false;
            }
            else
            {
                this.dataGridViewCuponesDevueltos.Visible = false;
                this.dataGridViewGifcardAcreditadas.Visible = true;
            }
        }
    }
}
