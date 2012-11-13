namespace GrouponDesktop.Homes
{
    public static class HomeFactory
    {
        private static string ConnectionString
        {
            get { return @"Data Source=localhost\SQLSERVER2008;Initial Catalog=GD2C2012;User ID=gd;Password=gd2012"; }
        }

        private static UsuarioHome usuarioHome;
        public static UsuarioHome Usuario 
        { 
            get { return usuarioHome ?? (usuarioHome = new UsuarioHome(ConnectionString)); }
        }
    }
}
