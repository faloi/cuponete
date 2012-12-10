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

        public RegistroRolView() : this(new Rol()) {}
        
        public RegistroRolView(Rol rol)
        {
            InitializeComponent();

            this.home = HomeFactory.Rol;
            this.SetBindingSource(rol);

            this.Text = "Registro de Rol";
            this.CreateBindings(this.buttonAceptar);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxNombre.BindTextTo(this.model, "descripcion");
            
            CargarFuncionalidades();
            if(isModificar())
                this.FiltrarFuncionalidades();
            
        }

        private bool isModificar()
        {
            return ((this.model.DataSource as Rol).id_rol!=0)
            ;

        }

        protected override void ExecSubmit()
        {
            if (isModificar())
                this.home.ModificarRol(this, model.DataSource as Rol,
                                       this.checkedListBoxFuncionalidades.GetCheckedItems<Funcionalidad>());
            else
                 this.home.RegistrarRol(this.model.DataSource as Rol, this.checkedListBoxFuncionalidades.GetCheckedItems<Funcionalidad>());
           
        }

        private void CargarFuncionalidades()
        {
            var funcionalidades = HomeFactory.Funcionalidad.FuncionalidadesDisponibles();
            checkedListBoxFuncionalidades.BindSourceTo(funcionalidades, "id_funcionalidad", "descripcion");
        }
       
        private void FiltrarFuncionalidades()
        {
            var funcionalidades = (HomeFactory.Funcionalidad.FuncionalidadesPorRol((this.model.DataSource as Rol).id_rol));
            var checkBoxItems = checkedListBoxFuncionalidades.DataSource as List<Funcionalidad>;
            foreach (var checkBoxItem in checkBoxItems)
            {
                Funcionalidad funcionalidad = checkBoxItem as Funcionalidad;
                if(funcionalidades.Any(obj=> obj.descripcion == funcionalidad.descripcion))
                    checkedListBoxFuncionalidades.SetItemChecked(checkBoxItems.IndexOf(checkBoxItem),true);
            }
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
