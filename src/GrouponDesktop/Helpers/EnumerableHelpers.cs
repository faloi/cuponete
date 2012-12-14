using System.Collections.Generic;
using System.Linq;

namespace GrouponDesktop.Helpers
{
    public static class EnumerableHelpers
    {
        public static T GetValue<T>(this IEnumerable<KeyValuePair<string, T>> items, string key)
        {
            return items.First(item => item.Key == key).Value;
        }
    }
}
