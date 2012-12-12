using System.Collections.Generic;
using System.Linq;

namespace GrouponDesktop.Sql
{
    public class Filters
    {
        private readonly List<string> filters;

        public Filters()
        {
            this.filters = new List<string>();
        }

        public void AddLike(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} LIKE '%{1}%'", columnName, value));
        }

        public void AddEqual(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} = '{1}'", columnName, value));
        }

        public void AddMenor(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} < '{1}'", columnName, value));
        }

        public void AddMayor(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} > '{1}'", columnName, value));
        }

        public void AddMenorIgual(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} <= '{1}'", columnName, value));
        }

        public void AddMayorIgual(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} >= '{1}'", columnName, value));
        }

        public string Build()
        {
            if (!this.filters.Any())
                return string.Empty;

            return this.filters
                .Aggregate("WHERE", (acum, filter) => acum + " " + filter + " AND")
                .Substring(0, this.filters.Aggregate("WHERE", (acum, filter) => acum + " " + filter + " AND").Length - 4);
        }
    }
}