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

        public string Build()
        {
            if (!this.filters.Any())
                return string.Empty;

            var aggregate = this.filters.Aggregate("WHERE", (acum, filter) => acum + " " + filter + " AND");
            return aggregate.Substring(0, aggregate.Length - 4);
        }
    }
}