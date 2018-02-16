using System.Collections.Generic;

namespace FunctionalMethodsCsharp.Where
{
    public static class WhereWithLoop
    {
        private static readonly List<int> numbers = new List<int> { 30, 40, 99 };

        public static IEnumerable<int> LessThan50()
        {
            var newCollection = new List<int>();

            foreach (var number in numbers)
            {
                if (number < 50)
                {
                    newCollection.Add(number);
                }
            }

            return newCollection;
        }
    }
}
