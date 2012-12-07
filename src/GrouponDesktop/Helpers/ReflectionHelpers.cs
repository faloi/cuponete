using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace GrouponDesktop.Helpers
{
    public static class ReflectionHelpers
    {
        public static bool IsAutomaticProperty(this PropertyInfo property)
        {
            return (property.GetGetMethod() ?? property.GetSetMethod()).IsDefined(typeof (CompilerGeneratedAttribute), false);
        }

        public static void SetPropertyIfExists(this object instance, string name, object value)
        {
            try
            {
                instance.GetType().GetProperty(name).SetValue(instance, value, null);
            }
            catch (NullReferenceException) {}
        }
    }
}