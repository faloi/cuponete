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
    public partial class DevolverCupon : DefaultView
    {
        private readonly CuponHome home;

        public DevolverCupon(CuponParaDevolucion cuponParaDevolucion)
        {
            InitializeComponent();
            this.home = HomeFactory.Cupon;
            this.SetBindingSource(this.home.GetCuponParaDevolucion(cuponParaDevolucion));
            this.tipoUsuarioDisponible = CLIENTE;

            this.Setup();
        }

        private void Setup()
        {
            this.Text = "Devolver Cupón";
            this.CreateBindings(this.buttonSolicitar);
        }

        protected override void CreateSpecificBindings()
        {
            
            this.richTextBoxDescripcion.BindTextTo(this.model, "descripcion");
            this.fecVencimientoCanje.BindTextToDate(this.model, "fec_venc_consumo","dd/MM/yyyy");
            this.textBoxPrecio.BindTextTo(this.model, "precio_real");
            this.richTextBoxMotivo.BindTextTo(this.model, "motivo_devolucion");
            this.buttonCancelar.Click +=
                (sender, args) => this.Close();
        }

        protected override void ExecSubmit()
        {
            var cuponParaDevolucion = this.model.DataSource as CuponParaDevolucion;
            cuponParaDevolucion.id_cliente = HomeFactory.Usuario.UsuarioActual.id_usuario;
            cuponParaDevolucion.fecha_devolucion = ControlBindingHelpers.FechaSistema;
            this.home.DevolverCupon(this.model.DataSource as CuponParaDevolucion);
            this.SuccessMessage("La devolución se registro correctamente");
        }

        protected override bool Validar()
        {
            var fieldsObligatorios = new List<RichTextBox>
               {
                   this.richTextBoxMotivo,
                
               };
            return (ValidatorHelper.ValidateObligatorio(fieldsObligatorios, this.errorProvider));

        }

    }
}
