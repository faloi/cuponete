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
    }
}