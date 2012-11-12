namespace GrouponDesktop.Repositories
{
    public static class RepoFactory
    {
        private static string ConnectionString
        {
            get { return @"Data Source=localhost\SQLSERVER2008;Initial Catalog=GD2C2012;User ID=gd;Password=gd2012"; }
        }

        public static UserRepository User { get { return new UserRepository(ConnectionString);}}
    }
}
