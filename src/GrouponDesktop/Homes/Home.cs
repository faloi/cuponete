using GrouponDesktop.Sql;

namespace GrouponDesktop.Homes
{
    public abstract class Home
    {
        protected readonly SqlRunner sqlRunner;

        protected Home(string connectionString)
        {
            this.sqlRunner = new SqlRunner(connectionString);
        }

        protected void RunProcedure(string name, object model)
        {
            var procedureName = string.Format("RANDOM.{0}", name);
            var parameters = new Adapter().CreateParametersFrom(model);
            
            this.sqlRunner.Run(Runnable.StoreProcedure(procedureName, parameters));
        }
    }
}