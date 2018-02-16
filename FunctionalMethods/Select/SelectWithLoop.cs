using System.Collections.Generic;

namespace FunctionalMethods.Select
{
    public static class SelectWithLoop
    {
        private static List<string> words = new List<string> { "foo", "bar", "baz" };

        public static IEnumerable<string> ToUpper()
        {
            var newCollection = new List<string>();

            foreach (var word in words)
            {
                newCollection.Add(word.ToUpper());
            }

            return newCollection;
        }
    }
}
