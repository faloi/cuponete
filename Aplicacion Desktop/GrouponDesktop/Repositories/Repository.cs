using GrouponDesktop.Sql;

namespace GrouponDesktop.Repositories
{
    public abstract class Repository
    {
        protected readonly SqlRunner sqlRunner;

        protected Repository(string connectionString)
        {
            this.sqlRunner = new SqlRunner(connectionString);
        }
    }
}