using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

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
            this.tipoUsuarioDisponible = TODOS;
            this.Text = "Registro de Rol";
            this.CreateBindings(this.buttonAceptar);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxNombre.BindTextTo(this.model, "descripcion");
            
            CargarFuncionalidades();
            if(isModificar())
                this.FiltrarFuncionalidades();

            this.buttonCancelar.Click +=
                (sender, args) => this.Close();
            
        }

        private bool isModificar()
        {
            return ((this.model.DataSource as Rol).id_rol!=0)
            ;

        }

        protected override void ExecSubmit()
        {
            if (isModificar())
                this.home.ModificarRol(model.DataSource as Rol,
                                       this.checkedListBoxFuncionalidades.GetCheckedItems<Funcionalidad>());
            else
                 this.home.RegistrarRol(this.model.DataSource as Rol, this.checkedListBoxFuncionalidades.GetCheckedItems<Funcionalidad>());
            this.SuccessMessage("El rol se guardo correctamente");
           
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

    }
}
