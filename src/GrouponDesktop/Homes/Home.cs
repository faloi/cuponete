using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GrouponDesktop.Sql;

namespace GrouponDesktop.Homes
{
    public abstract class Home
    {
        protected readonly SqlRunner sqlRunner;

        protected Home(string connectionString)
        {
            this.sqlRunner = new TransactionalSqlRunner(connectionString);
        }

        protected Runnable CreateProcedureFrom(string name, object model, params string[] parametersNames)
        {
            var procedureName = string.Format("RANDOM.{0}", name);
            var parameters = new Adapter().CreateParametersFrom(model, parametersNames);

            return Runnable.StoreProcedure(procedureName, parameters);
        }

        protected Runnable CreateProcedureFrom(string name, Dictionary<string, object> values)
        {
            var procedureName = string.Format("RANDOM.{0}", name);
            var parameters = new Adapter().CreateParametersFrom(values);

            return Runnable.StoreProcedure(procedureName, parameters);
        }

        protected void RunProcedures(IEnumerable<Runnable> procedures)
        {
            try
            {
                this.sqlRunner.Run(procedures);
            }
            catch (SqlException e)
            {
                if (e.Class < 16)
                    throw;

                throw new ApplicationException(e.Message, e);
            }
        }
    }
}