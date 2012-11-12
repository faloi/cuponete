using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace GrouponDesktop.Sql
{
    public class Adapter
    {
        public IEnumerable<T> TransformMany<T>(DataTable dataTable)
        {
            return dataTable.Rows
                .Cast<DataRow>()
                .Select(row => this.Transform<T>(row));
        }

        public T Transform<T>(DataRow dataRow)
        {
            var entity = Activator.CreateInstance<T>();

            var properties = typeof (T)
                .GetProperties()
                .Where(p => (p.GetGetMethod() ?? p.GetSetMethod()).IsDefined(typeof(CompilerGeneratedAttribute), false));

            foreach (var property in properties)
                property.SetValue(entity, this.ConvertValue(dataRow, property), null);

            return entity;
        }

        private object ConvertValue(DataRow dataRow, PropertyInfo property)
        {
            return Convert.ChangeType(dataRow[property.Name], property.PropertyType, CultureInfo.InvariantCulture);
        }
    }
}