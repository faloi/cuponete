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
using GrouponDesktop.Sql;

namespace GrouponDesktop.Views
{
    public partial class ArmarCupon : DefaultView
    {

        private readonly CuponHome home;

        public ArmarCupon()
        {
            InitializeComponent();
            this.home = HomeFactory.Cupon;
            this.SetBindingSource(new Cupon());
            this.tipoUsuarioDisponible = PROVEEDOR;

            this.Text = "Armar Cupón";
            this.CreateBindings(this.buttonArmarCupon);
        }

       protected override void CreateSpecificBindings()
        {
            this.textBoxDescripcion.BindTextTo(this.model, "descripcion");
            this.fecPub.BindTextToDate(this.model, "fec_publicacion", "dd/MM/yyyy");
            this.fecVencPubdateTime.BindTextToDate(this.model, "fec_venc_publicacion", "dd/MM/yyyy");
            this.fecVencCanjdateTime.BindTextToDate(this.model, "fec_venc_consumo", "dd/MM/yyyy");
            this.textBoxPrecioReal.BindTextTo(this.model, "precio_real");
            this.textBoxPrecioFicticio.BindTextTo(this.model, "precio_ficticio");
            this.textBoxCantDisp.BindTextTo(this.model, "cant_disp");
            this.textBoxMaxCant.BindTextTo(this.model, "max_compra_por_usuario");

            CargarCiudadesPref();

            this.buttonCancelar.Click +=
                (sender, args) => this.Close();

        }

        private void CargarCiudadesPref()
        {
            var ciudades = new Adapter().TransformMany<Ciudad>(HomeFactory.Ciudad.CiudadesDisponibles());
            checkedListBoxCiudades.BindSourceTo(ciudades, "id_ciudad", "descripcion");
        }

        protected override void ExecSubmit()
        {
            var cupon = this.model.DataSource as Cupon;
            cupon.id_proveedor = HomeFactory.Usuario.UsuarioActual.id_usuario;
            cupon.fecha_actual = ControlBindingHelpers.GetFechaSistema();
            var ciudadesSeleccionadas = this.checkedListBoxCiudades.GetCheckedItems<Ciudad>();
            this.home.ArmarCupon(cupon, ciudadesSeleccionadas);
            this.SuccessMessage("El cupón ser registro correctamente");
        }

        protected override bool Validar()
        {
            var fieldsObligatorios = new List<TextBox>
            {
               this.textBoxDescripcion,
               this.textBoxPrecioReal,
               this.textBoxPrecioFicticio,
               this.textBoxCantDisp,
               this.textBoxMaxCant               
            };


            return (ValidatorHelper.ValidateObligatorio(fieldsObligatorios, this.errorProvider) && ValidatorHelper.ValidateCheckList(this.checkedListBoxCiudades, this.errorProvider));
        }

    }
}
