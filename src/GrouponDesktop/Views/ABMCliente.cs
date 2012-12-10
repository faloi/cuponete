using System.Collections.Generic;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class ABMCliente : ListadoView
    {
        private readonly UsuarioHome home;

        public ABMCliente()
        {
            InitializeComponent();
            this.home = HomeFactory.Usuario;
            this.Example = new Cliente();
            this.Setup();
        }

        private void Setup()
        {
            this.rolDisponible = ADMINISTRADOR;
            this.Text = "Listado de Clientes";
            this.CreateBindings(this.buttonBuscar);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxNombre.BindTextTo(this.Example, "nombre");
            this.textBoxApellido.BindTextTo(this.Example, "apellido");
            this.textBoxEmail.BindTextTo(this.Example, "mail");
            this.textBoxDNI.BindTextTo(this.Example, "dni", DataType.INTEGER);

            this.clientesDataGrid.BindSourceTo(this.Data, new Dictionary<string, string>
            {
                {"Nombre", "nombre"},
                {"Apellido", "apellido"},
                {"DNI", "dni"},
                {"Email", "mail"}
            });

            this.limpiarButton.Click += 
                (sender, args) => this.Example = new Cliente();
        }

        protected override void ExecSubmit()
        {
            this.Data = this.home.ListarClientes(this.Filter as Cliente);
        }
    }
}
