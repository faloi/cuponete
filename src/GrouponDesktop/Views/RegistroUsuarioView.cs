﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Views
{
    public partial class RegistroUsuarioView : DefaultView
    {
        private readonly UsuarioHome home;
      

        public RegistroUsuarioView()
        {
            InitializeComponent();

            this.home = HomeFactory.Usuario;
            this.SetBindingSource(new Cliente());

            this.Setup();
        }

        private void Setup()
        {
            this.Text = "Registro de Usuario";
            this.CreateBindings(this.guardarButton);
        }

        protected override void CreateSpecificBindings()
        {
            this.username.BindTextTo(this.model, "username");
            this.password.BindTextTo(this.model, "password");
            this.apellidoCliente.BindTextTo(this.model,"apellido");
            this.nombreCliente.BindTextTo(this.model, "nombre");
            this.dniCliente.BindTextTo(this.model, "dni", DataType.INTEGER);
            this.emailCliente.BindTextTo(this.model, "mail");
            this.telefonoCliente.BindTextTo(this.model, "telefono");
            this.calleCliente.BindTextTo(this.model, "direccionCalle");
            this.numeroDirCliente.BindTextTo(this.model, "direccionNumero");
            this.dptoDirCliente.BindTextTo(this.model, "direccionDto");
            this.localidadCliente.BindTextTo(this.model, "direccionLocalidad");
            this.cpostalCliente.BindTextTo(this.model, "cod_postal");
            this.fechaNacCliente.BindTextToDate(this.model, "fecha_nac", "dd/MM/yyyy");

            this.limpiarButton.Click +=
                (sender, args) => this.model.DataSource = new Cliente();

            this.CargarRoles();
            this.CargarCiudadesPref();
            this.CargarRubros();
            this.CargarCiudadesProv();
        }

        protected override void ExecSubmit()
        {
            if (this.EsCliente)
                this.home.RegistrarCliente(this.model.DataSource as Cliente, this.ciuPrefClienteBox.GetCheckedItems<Ciudad>());
            else
                this.home.RegistrarProveedor(this.model.DataSource as Proveedor);
           

        }

        private void CargarRoles()
        {
            var roles = new Adapter().TransformMany<Rol>(HomeFactory.Rol.RolesDisponibles());
            this.comboRol.BindSourceTo(roles, "id_rol", "descripcion");

        }

        private void CargarRubros()
        {
            var rubros = new Adapter().TransformMany<Rubro>(HomeFactory.Rubro.RubrosDisponibles());
            this.comboRubro.BindSourceTo(rubros, "id_rubro", "desc_rubro");

        }

        private void CargarCiudadesProv()
        {
            var ciudades = new Adapter().TransformMany<Ciudad>(HomeFactory.Ciudad.CiudadesDisponibles());
            ciudadProvCombo.BindSourceTo(ciudades, "id_ciudad", "descripcion");
        }


        private void CargarCiudadesPref()
        {
            var ciudades = new Adapter().TransformMany<Ciudad>(HomeFactory.Ciudad.CiudadesDisponibles());
            ciuPrefClienteBox.BindSourceTo(ciudades, "id_ciudad", "descripcion");
        }

        private void ComboRolSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.EsCliente)
            {
                this.proveedorGroupBox.Visible = false;
                this.clienteGroupBox.Visible = true;
            }
            else
            {
                this.proveedorGroupBox.Visible = true;
                this.clienteGroupBox.Visible = false;   
            }
                
        }

        private bool EsCliente
        {
            get { return ((Rol) this.comboRol.SelectedItem).descripcion.Equals("Cliente"); }
        }

        protected override bool Validar()
        {
            List<TextBox> fieldsObligatorios = new List<TextBox>();
            fieldsObligatorios.Add(this.nombreCliente);
            fieldsObligatorios.Add(this.apellidoCliente);
            fieldsObligatorios.Add(this.dniCliente);
            fieldsObligatorios.Add(this.emailCliente);
            fieldsObligatorios.Add(this.calleCliente);
            fieldsObligatorios.Add(this.numeroDirCliente);
            fieldsObligatorios.Add(this.telefonoCliente);
            fieldsObligatorios.Add(this.username);
            fieldsObligatorios.Add(this.password);
            fieldsObligatorios.Add(this.repitaPassword);
            return ValidatorHelper.ValidateObligatorio(fieldsObligatorios,errorProvider);
        }
    }
}
