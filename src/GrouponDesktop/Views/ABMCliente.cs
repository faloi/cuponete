
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class ABMCliente : DefaultView
    {
       
        private readonly Cliente model;
        private UsuarioHome home;

        public ABMCliente()
        {
            InitializeComponent();
            this.home = HomeFactory.Usuario;
            this.SetBindingSource(new Cliente());

            this.Setup();
        }

        private void Setup()
        {
            this.Text = "Listado de Clientes";
            this.CreateBindings(this.buttonBuscar);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxApellido.BindTextTo(this.model, "apellido");
            this.textBoxNombre.BindTextTo(this.model, "nombre");
            this.textBoxDNI.BindTextTo(this.model,"dni");
            this.textBoxEmail.BindTextTo(this.model,"email"); 
        }

        protected override void ExecSubmit()
        {
            this.home.ListarClientes();
        }


    }
}
