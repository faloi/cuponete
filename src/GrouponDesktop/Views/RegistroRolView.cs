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
    public partial class RegistroRolView : DefaultView
    {

        private readonly RolHome home;
        public RegistroRolView()
        {
            InitializeComponent();
            this.home = HomeFactory.Rol;
            this.SetBindingSource(new Rol());

            this.Setup();

        }

        private void Setup()
        {
            this.Text = "Registro de Rol";
            this.CreateBindings(this.buttonAceptar);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxNombre.BindTextTo(this.model, "descripcion");
            this.CargarFuncionalidades();
        }

        protected override void ExecSubmit()
        {
            this.home.RegistrarRol(this.model.DataSource as Rol, this.checkedListBoxFuncionalidades.GetCheckedItems<Funcionalidad>());
           
        }

        private void CargarFuncionalidades()
        {
            var funcionalidades = new Adapter().TransformMany<Funcionalidad>(HomeFactory.Funcionalidad.FuncionalidadesDisponibles());
            checkedListBoxFuncionalidades.BindSourceTo(funcionalidades, "id_funcionalidad", "descripcion");
        }

        protected override bool Validar()
        {
            var fieldsObligatorios = new List<TextBox>
               {
                   this.textBoxNombre
               };
            return (ValidatorHelper.ValidateObligatorio(fieldsObligatorios, this.errorProvider) && ValidatorHelper.ValidateCheckList(this.checkedListBoxFuncionalidades, this.errorProvider));
             
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
