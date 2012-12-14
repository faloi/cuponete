using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

        protected Runnable CreateProcedureFrom(string name, IEnumerable<string> fieldsToReplace, Dictionary<string, object> values)
        {
            var runnable = this.CreateProcedureFrom(name, values);
            runnable.ParametersToReplace = fieldsToReplace;

            return runnable;
        }

        protected Runnable CreateProcedureFrom(string name, Dictionary<string, object> values)
        {
            var procedureName = string.Format("RANDOM.{0}", name);
            var parameters = new Adapter().CreateParametersFrom(values);

            return Runnable.StoreProcedure(procedureName, parameters);
        }

        protected Dictionary<string, string> Run(Runnable procedure)
        {
            return this.Run(new[] { procedure });
        }

        protected Dictionary<string, string> Run(IEnumerable<Runnable> procedures)
        {
            try
            {
                return this.sqlRunner
                    .Run(procedures)
                    .ToDictionary(pair => pair.Key, pair => pair.Value);
            }
            catch (SqlException e)
            {
                if (e.Class < 16)
                    throw;

                var message = e.Message.Contains("\r")
                    ? e.Message.Split('\r')[0]
                    : e.Message;

                throw new ApplicationException(message, e);
            }
        }
    }
}