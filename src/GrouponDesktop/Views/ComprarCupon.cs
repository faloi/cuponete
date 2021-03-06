﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class ComprarCupon : ListadoView<Cupon, CuponHome>
    {
        public ComprarCupon() : base(HomeFactory.Cupon) {}

        protected override void Setup()
        {
            this.InitializeComponent();
            this.tipoUsuarioDisponible = CLIENTE;
            this.Text = "Comprar Cupón";
            this.CreateBindings(this.buttonComprarCupon,buttonComprarCupon,cuponDataGrid);
            this.listaCupones();
        }

        private void listaCupones()
        {
            this.Data = this.home.CuponesDisponibles(ControlBindingHelpers.FechaSistema);
        }

        protected override void CreateSpecificBindings()
        {
            this.cuponDataGrid.BindSourceTo(this.Data,"id_cupon", new Dictionary<string, string>
            {
                {"Descripcion", "descripcion"},
                {"Precio Ficticio", "precio_ficticio"},
                {"Precio Real", "precio_real"}
           });

            this.buttonCancelar.Click +=
               (sender, args) => this.Close();
        }

        protected override void ExecSubmit()
        {
            var cupon = this.home.GetCuponById(this.IdSeleccionado);
            var cuponComprado = new Cupon_comprado();
            cuponComprado.id_cupon = cupon.id_cupon;
            cuponComprado.fecha_compra = ControlBindingHelpers.FechaSistema;
            cuponComprado.codigo_compra = "";
            cuponComprado.id_cliente = HomeFactory.Usuario.UsuarioActual.id_usuario;
            this.home.ComprarCupon(cuponComprado);
            this.Redirect(new PopUpCuponComprado(cuponComprado));
            this.Close();
        }

        private string IdSeleccionado
        {
            get { return this.cuponDataGrid.GetSelectedItem<Cupon>().id_cupon.ToString(); }
        }
    }
}
