using System.Collections.Generic;
using System.Linq;

namespace FunctionalMethodsCsharp.Select
{
    public static class SelectWithLinq
    {
        private static readonly List<string> words = new List<string> { "foo", "bar", "baz" };

        public static IEnumerable<string> ToUpper()
        {
            return words.Select(item => item.ToUpper());
        }
    }
}
