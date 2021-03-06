﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Views
{
    public partial class ModificarProveedor : DefaultView
    {
        private readonly UsuarioHome home;
        private bool IsNew { get; set; }

        public ModificarProveedor() : this(new Proveedor(), true) {}

        public ModificarProveedor(Proveedor proveedor) : this(proveedor, false) {}

        private ModificarProveedor(Proveedor proveedor, bool isNew)
        {
            InitializeComponent();
            this.tipoUsuarioDisponible = TODOS;
            this.IsNew = isNew;
            this.usuarioGroupBox.Visible = this.limpiarButton.Visible = this.direccionGroupBox.Visible = this.IsNew;

            this.home = HomeFactory.Usuario;
            this.SetBindingSource(proveedor);

            this.Text = "Modificar Proveedor";
            this.CreateBindings(this.guardarButton);
            this.password.UseSystemPasswordChar = true;
        }

        protected override void CreateSpecificBindings()
        {
            this.razonSocial.BindTextTo(this.model, "razon_social");
            this.email.BindTextTo(this.model, "mail");
            this.telefono.BindTextTo(this.model, "telefono", DataType.INTEGER);
            this.codigoPostal.BindTextTo(this.model, "cod_postal", DataType.INTEGER);
            this.cuit.BindTextTo(this.model, "cuit");
            this.contacto.BindTextTo(this.model, "contacto_nombre");

            if (this.IsNew)
            {
                this.username.BindTextTo(this.model, "username");
                this.password.BindTextTo(this.model, "password");
                this.calle.BindTextTo(this.model, "direccionCalle");
                this.numero.BindTextTo(this.model, "direccionNumero", DataType.INTEGER);
                this.piso.BindTextTo(this.model, "direccionPiso");
                this.depto.BindTextTo(this.model, "direccionDto");
                this.localidad.BindTextTo(this.model, "direccionLocalidad");
            }
            else
            {
                this.direccion.BindTextTo(this.model, "direccion");
            }

            this.CargarRubros();
            this.CargarCiudadesProv();

            this.limpiarButton.Click +=
                (sender, args) => this.SetBindingSource(new Proveedor());
        }

        protected override void ExecSubmit()
        {
            try
            {
                var proveedor = this.model.DataSource as Proveedor;

                if (this.IsNew)
                    this.home.RegistrarProveedor(proveedor);
                else
                    this.home.ModificarProveedor(proveedor);

                this.SuccessMessage("Los datos se guardaron correctamente");
            }
            catch(Exception)
            {
                this.password.Text = null;
                throw;
            }
        }

        protected override bool Validar()
        {
            var fieldsObligatorios = new List<TextBox>
            {
               this.razonSocial,
               this.telefono,
               this.email,
               this.cuit,
               this.contacto,
               this.codigoPostal
            };

            if (this.IsNew)
                fieldsObligatorios.AddRange(new[] { this.username, this.password, this.calle, this.numero, this.localidad });
            else
                fieldsObligatorios.Add(this.direccion);

            var obligatorios = ValidatorHelper.ValidateObligatorio(fieldsObligatorios, this.errorProvider);
            var rubro = ValidatorHelper.ValidateComboBox(this.comboRubro, this.errorProvider);
            var ciudad = ValidatorHelper.ValidateComboBox(this.ciudadProvCombo, this.errorProvider);
            
            return obligatorios && rubro && ciudad;
        }

        private void CargarRubros()
        {
            var rubros = new Adapter().TransformMany<Rubro>(HomeFactory.Rubro.RubrosDisponibles());
            this.comboRubro.BindSourceTo(rubros, "id_rubro", "desc_rubro");
            this.comboRubro.BindValueTo(this.model, "id_rubro");
        }

        private void CargarCiudadesProv()
        {
            var ciudades = new Adapter().TransformMany<Ciudad>(HomeFactory.Ciudad.CiudadesDisponibles());
            this.ciudadProvCombo.BindSourceTo(ciudades, "id_ciudad", "descripcion");
            this.ciudadProvCombo.BindValueTo(this.model, "id_ciudad");
        }
    }
}
