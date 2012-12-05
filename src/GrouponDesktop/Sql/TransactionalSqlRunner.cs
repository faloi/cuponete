using System.Collections.Generic;
using System.Data.SqlClient;

namespace GrouponDesktop.Sql
{
    public class TransactionalSqlRunner : SqlRunner
    {
        private SqlTransaction transaction;

        public TransactionalSqlRunner(string connectionString) : base(connectionString) { }

        protected override void PostConnectionAction(SqlConnection connection)
        {
            this.transaction = connection.BeginTransaction();
        }

        protected override void ExecuteCommand(IEnumerable<Runnable> runnables, SqlCommand command)
        {
            try
            {
                command.Transaction = this.transaction;

                foreach (var runnable in runnables)
                    runnable.Run(command);

                transaction.Commit();
            }
            catch (SqlException)
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}
