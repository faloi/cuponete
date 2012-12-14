using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
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
            this.SetBindingSource(cuponParaDevolucion);
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
            this.buttonCancelar.Click +=
                (sender, args) => this.Close();
        }

    }
}
