using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class ABMCliente : ListadoView<Cliente, UsuarioHome>
    {
        public ABMCliente() : base(HomeFactory.Usuario) {}

        private string IdSeleccionado
        {
            get { return this.clientesDataGrid.GetSelectedItem<Cliente>().id_usuario.ToString(); }
        }

        protected override void Setup()
        {
            this.InitializeComponent();
            this.tipoUsuarioDisponible = ADMINISTRADOR;
            this.Text = "Listado de Clientes";
            this.CreateBindings(this.buttonBuscar, this.limpiarButton, this.buttonModificar, this.buttonBajaRestaurar, this.clientesDataGrid);
        }

        protected override void CreateSpecificBindings()
        {
            this.textBoxNombre.BindTextTo(this.Example, "nombre");
            this.textBoxApellido.BindTextTo(this.Example, "apellido");
            this.textBoxEmail.BindTextTo(this.Example, "mail");
            this.textBoxDNI.BindTextTo(this.Example, "dni", DataType.INTEGER);

            this.clientesDataGrid.BindSourceTo(this.Data, "id_usuario", new Dictionary<string, string>
            {
                {"Nombre", "nombre"},
                {"Apellido", "apellido"},
                {"DNI", "dni"},
                {"Email", "mail"},
                {"Estado", "descripcion_estado"}
            });

            this.buttonNuevoCliente.Click +=
                (sender, args) => this.NuevoCliente();

            this.buttonModificar.Click +=
                (sender, args) => this.ModificarCliente();

            this.buttonBajaRestaurar.Click +=
                (sender, args) => this.BajaRestaurarCliente();
        }

        private void NuevoCliente()
        {
            new ModificarCliente().ShowDialog();
            this.ExecSubmit();
        }

        private void BajaRestaurarCliente()
        {
            var cliente = this.home.GetClienteById(this.IdSeleccionado);
            if (cliente.estado == 0)
            {
                this.home.DarDeAltaUsuario(cliente);
                MessageBox.Show("El cliente se Habilito con éxito");
            }
            else
            {
                this.home.DarDeBajaUsuario(cliente);
                MessageBox.Show("El cliente se Deshabilito con éxito");
            }

            this.ExecSubmit();
        }

        private void ModificarCliente()
        {
            var cliente = this.home.GetClienteById(this.IdSeleccionado);
            new ModificarCliente(cliente).ShowDialog();

            this.ExecSubmit();    
        }

        protected override void ExecSubmit()
        {
            this.Data = this.home.ListarClientes(this.Filter);
        }
    }
}
