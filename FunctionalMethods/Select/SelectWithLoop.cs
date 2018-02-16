using System.Collections.Generic;

namespace FunctionalMethods.Select
{
    public static class SelectWithLoop
    {
        private static readonly List<string> Words = new List<string> { "foo", "bar", "baz" };

        public static IEnumerable<string> ToUpper()
        {
            var newCollection = new List<string>();

            foreach (var word in Words)
            {
                newCollection.Add(word.ToUpper());
            }

            return newCollection;
        }
    }
}
