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
    public partial class PedirDevolucion : DefaultView
    {
        private readonly CuponHome home;

        public PedirDevolucion()
        {

            InitializeComponent();
            this.home = HomeFactory.Cupon;
            this.SetBindingSource(new CuponParaDevolucion());
            this.tipoUsuarioDisponible = CLIENTE;

            this.Setup();
        }

        private void Setup()
        {
            this.Text = "Pedir Devolución";
            this.CreateBindings(this.buttonSolicitar);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxCodigo.BindTextTo(this.model, "codigo_compra");
            this.buttonCancelar.Click +=
                (sender, args) => this.Close();
        }

        protected override void ExecSubmit()
        {
            var cuponParaDevolucion = this.model.DataSource as CuponParaDevolucion;
            cuponParaDevolucion.id_cliente = HomeFactory.Usuario.UsuarioActual.id_usuario;
            cuponParaDevolucion.fecha_devolucion = ControlBindingHelpers.FechaSistema;
            this.home.PedirDevolucion(cuponParaDevolucion);      
            this.Redirect(new DevolverCupon(cuponParaDevolucion),true);
        }

        protected override bool Validar()
        {
            var fieldsObligatorios = new List<TextBox>
               {
                   this.textBoxCodigo,
                
               };
            return (ValidatorHelper.ValidateObligatorio(fieldsObligatorios, this.errorProvider));

        }
    }
}
