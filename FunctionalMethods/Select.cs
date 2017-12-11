using System.Collections.Generic;
using System.Linq;

namespace FunctionalMethods
{
    public static class Select
    {
        private static List<string> words = new List<string> { "foo", "bar", "baz" };

        public static IEnumerable<string> ToUpperWithLoops()
        {
            var newCollection = new List<string>();

            foreach (var word in words)
            {
                newCollection.Add(word.ToUpper());
            }

            return newCollection;
        }

        public static IEnumerable<string> ToUpperWithLinq()
        {
            return words.Select(item => item.ToUpper());
        }
    }
}
