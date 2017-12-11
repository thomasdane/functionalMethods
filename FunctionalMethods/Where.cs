using System.Collections.Generic;
using System.Linq;

namespace FunctionalMethods
{
    public static class Where
    {
        private static List<int> numbers = new List<int> { 30, 40, 99 };

        public static IEnumerable<int> LessThan50WithLoops()
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

        public static IEnumerable<int> LessThan50WithLinq()
        {
            return numbers.Where(number => number < 50);
        }
    }
}
