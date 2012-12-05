using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace GrouponDesktop.Sql
{
    public class SqlRunner
    {
        private readonly string connectionString;

        public SqlRunner(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Run(IEnumerable<Runnable> runnables)
        {
            this.Run(runnables.ToArray());
        }

        public void Run(params Runnable[] runnables)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                this.PostConnectionAction(connection);

                using (var command = new SqlCommand { Connection = connection })
                    this.ExecuteCommand(runnables, command);
            }
        }

        public DataTable Select(string query, params string[] parameters)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand { Connection = connection })
                {
                    var queryWithParameters = string.Format(query, parameters);
                    return Runnable.Query(queryWithParameters).Select(command);
                }
            }
        }

        public DataTable Select(string query, Filters filters)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand { Connection = connection })
                {
                    var queryWithParameters = query + " " + filters.Build();
                    return Runnable.Query(queryWithParameters).Select(command);
                }
            }
        }


        public DataRow Single(string query, params string[] parameters)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand { Connection = connection })
                {
                    var queryWithParameters = string.Format(query, parameters);
                    return Runnable.Query(queryWithParameters).Single(command);
                }
            }
        }

        protected virtual void ExecuteCommand(IEnumerable<Runnable> runnables, SqlCommand command)
        {
            foreach (var runnable in runnables)
                runnable.Run(command);
        }

        protected virtual void PostConnectionAction(SqlConnection connection) { }
    }
}