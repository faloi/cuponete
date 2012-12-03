using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace GrouponDesktop.Sql
{
    public class Adapter
    {
        public IList<T> TransformMany<T>(DataTable dataTable)
        {
            return dataTable.Rows
                .Cast<DataRow>()
                .Select(row => this.Transform<T>(row))
                .ToList();
        }

        public T Transform<T>(DataRow dataRow)
        {
            var entity = Activator.CreateInstance<T>();

            var columnNames = dataRow.Table.Columns
                .Cast<DataColumn>()
                .Select(c => c.ColumnName);

            var properties = typeof (T).GetProperties();

            foreach (var property in columnNames.Select(columnName => properties.Single(p => p.Name == columnName)))
                property.SetValue(entity, this.ConvertValue(dataRow, property), null);
 
            return entity;
        }

        public IEnumerable<SqlParameter> CreateParametersFrom(object model)
        {
            var properties = model.GetType().GetProperties();
            return properties
                .Where(p => p.IsAutomaticProperty())
                .Select(property => new SqlParameter(property.Name, property.GetValue(model, null)));
        }

        private object ConvertValue(DataRow dataRow, PropertyInfo property)
        {
            return Convert.ChangeType(dataRow[property.Name], property.PropertyType, CultureInfo.InvariantCulture);
        }
    }

    public static class ReflectionHelpers
    {
        public static bool IsAutomaticProperty(this PropertyInfo property)
        {
            return (property.GetGetMethod() ?? property.GetSetMethod()).IsDefined(typeof (CompilerGeneratedAttribute), false);
        }
    }
}