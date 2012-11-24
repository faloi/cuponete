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

        private static RolHome rolHome;
        public static RolHome Rol
        {
            get { return rolHome ?? (rolHome = new RolHome(ConnectionString)); }
        }

        private static CiudadHome ciudadHome;
        public static CiudadHome Ciudad
        {
            get { return ciudadHome ?? (ciudadHome = new CiudadHome(ConnectionString)); }
        }
       
    }
}
