namespace GrouponDesktop.Homes
{
    public static class HomeFactory
    {
        private static string ConnectionString
        {
            get { return Properties.Settings.Default.ConnectionString; }
        }

        private static UsuarioHome usuarioHome;
        public static UsuarioHome Usuario 
        { 
            get { return usuarioHome ?? (usuarioHome = new UsuarioHome(ConnectionString)); }
        }
    }
}
