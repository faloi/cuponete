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

        private static FuncionalidadHome funcionalidadHome;
        public static FuncionalidadHome Funcionalidad
        {
            get { return funcionalidadHome ?? (funcionalidadHome = new FuncionalidadHome(ConnectionString)); }
        }

        private static RubroHome rubroHome;
        public static RubroHome Rubro
        {
            get { return rubroHome ?? (rubroHome = new RubroHome(ConnectionString)); }
        }

        private static CuponHome cuponHome;
        public static CuponHome Cupon
        {
            get { return cuponHome ?? (cuponHome = new CuponHome(ConnectionString)); }
        }

        private static FormaPagoHome formaPagoHome;
        public static FormaPagoHome FormaPago
        {
            get { return formaPagoHome ?? (formaPagoHome = new FormaPagoHome(ConnectionString)); }
        }

        private static GiftCardHome giftCardHome;
        public static GiftCardHome GiftCard
        {
            get { return giftCardHome ?? (giftCardHome = new GiftCardHome(ConnectionString)); }
        }
    }
}
