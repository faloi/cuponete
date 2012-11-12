using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GrouponDesktop.Sql
{
    public class Runnable
    {
        private readonly string query;
        private readonly IEnumerable<SqlParameter> parameters;
        private readonly CommandType commandType;

        public static Runnable Query(string query)
        {
            return new Runnable(CommandType.Text, query);
        }

        public static Runnable StoreProcedure(string name, IEnumerable<SqlParameter> parameters)
        {
            return new Runnable(CommandType.StoredProcedure, name, parameters);
        }

        private Runnable(CommandType commandType, string query, IEnumerable<SqlParameter> parameters)
        {
            this.query = query;
            this.parameters = parameters;
            this.commandType = commandType;
        }

        private Runnable(CommandType commandType, string query) : this(commandType, query, new SqlParameter[0]) { }

        private void SetupCommand(SqlCommand command)
        {
            foreach (var p in parameters)
                command.Parameters.Add(p);

            command.CommandType = this.commandType;
            command.CommandText = this.query;
        }
        
        public void Run(SqlCommand command)
        {
            this.SetupCommand(command);
            command.ExecuteNonQuery();
        }

        public DataTable Select(SqlCommand command)
        {
            this.SetupCommand(command);

            var datatable = new DataTable();
            new SqlDataAdapter(command).Fill(datatable);

            return datatable;
        }

        public DataRow Single(SqlCommand command)
        {
            try
            {
                return this.Select(command).Rows[0];
            }
            catch (IndexOutOfRangeException e)
            {
                throw new NoResultsException(e);
            }
            
        }
    }

    public class NoResultsException : ApplicationException
    {
        public NoResultsException(Exception innerException) : base("La consulta no retorno resultados", innerException) {}
    }
}