﻿using System;
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
    public partial class FacturarProveedor : ListadoView<Factura, CuponHome>
    {
        public FacturarProveedor() : base(HomeFactory.Cupon) {}

        protected override void Setup()
        {
            this.InitializeComponent();
            this.tipoUsuarioDisponible = TODOS;
            this.CreateBindings(this.buttonBuscar, this.limpiarButton, this.buttonFacturar, new Button(), new Button(), this.cuponesDataGrid);
        }

        protected override void CreateSpecificBindings()
        {
            this.idProveedor.BindTextTo(this.Example, "id_proveedor", DataType.INTEGER);
            this.dateTimePickerDesde.BindTextTo(this.Example, "fecha_inicio");

            this.cuponesDataGrid.BindSourceTo(this.Data, new Dictionary<string, string>
            {
                {"Código compra", "codigo_compra"},    
                {"Fecha de canje", "fecha_canje"},
                {"Precio", "precio_real"}
            });

            this.buttonCancelar.Click +=
                (sender, args) => this.Close();

            this.buttonFacturar.Click += this.Facturar;

            this.lookupButton.Click +=
                (sender, args) => new ABMProveedor(this.idProveedor, "id_usuario").ShowDialog();
        }

        private void Facturar(object sender, EventArgs eventArgs)
        {
            this.home.Facturar(this.Filter);
            new ResumenDeFactura(this.Filter).ShowDialog();

            this.Close();
        }

        protected override bool Validar()
        {
            return ValidatorHelper.ValidateObligatorio(new[] {this.idProveedor}, this.errorProvider);
        }

        protected override void ExecSubmit()
        {
            this.Data = this.home.CuponesParaFacturar(this.Filter);
        }
    }
}
