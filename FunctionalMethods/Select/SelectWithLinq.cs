using System.Collections.Generic;
using System.Linq;

namespace FunctionalMethodsCsharp.Select
{
    public static class SelectWithLinq
    {
        private static readonly List<string> Words = new List<string> { "foo", "bar", "baz" };

        public static IEnumerable<string> ToUpper()
        {
            return Words.Select(item => item.ToUpper());
        }
    }
}
