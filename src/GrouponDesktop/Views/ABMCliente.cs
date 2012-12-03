using System.Collections.Generic;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class ABMCliente : DefaultView
    {
        private readonly UsuarioHome home;

        public ABMCliente()
        {
            InitializeComponent();
            this.home = HomeFactory.Usuario;

            this.Setup();
        }

        private void Setup()
        {
            this.Text = "Listado de Clientes";
            this.CreateBindings(this.buttonBuscar);
        }

        protected override void CreateSpecificBindings()
        {
            this.dataGridView1.BindSourceTo(this.model, new Dictionary<string, string>()
            {
                {"Nombre", "nombre"},
                {"Apellido", "apellido"},
                {"DNI", "dni"},
                {"Email", "mail"}
            });
        }

        protected override void ExecSubmit()
        {
            var clientes = this.home.ListarClientes();
            this.SetBindingSource(clientes);
        }
    }
}
