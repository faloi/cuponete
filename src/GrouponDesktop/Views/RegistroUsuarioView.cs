namespace GrouponDesktop.Views
{
    public partial class RegistroUsuarioView : DefaultView
    {
        public RegistroUsuarioView()
        {
            this.InitializeComponent();

            this.proveedorButton.Click += (sender, args) => this.AbrirProveedor();
            this.clienteButton.Click += (sender, args) => this.AbrirCliente();

        }

        public void AbrirCliente()
        {
            this.Redirect(new ModificarCliente());
            this.Close();
        }

        public void AbrirProveedor()
        {
            this.Redirect(new ModificarProveedor());
            this.Close();
        }
    }
}