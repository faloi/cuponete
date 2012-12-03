using System.Collections.Generic;
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

        protected void RunProcedure(string name, object model, params string[] parametersNames)
        {
            var procedureName = string.Format("RANDOM.{0}", name);
            var parameters = new Adapter().CreateParametersFrom(model, parametersNames);
            
            this.sqlRunner.Run(Runnable.StoreProcedure(procedureName, parameters));
        }

        protected void RunProcedure(string name, Dictionary<string, object> values)
        {
            var procedureName = string.Format("RANDOM.{0}", name);
            var parameters = new Adapter().CreateParametersFrom(values);

            this.sqlRunner.Run(Runnable.StoreProcedure(procedureName, parameters));
        }
    }
}