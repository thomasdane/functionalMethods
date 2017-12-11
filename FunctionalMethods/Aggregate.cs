using System.Collections.Generic;
using System.Linq;

namespace FunctionalMethods
{
    public static class Aggregate
    {
        private static List<int> numbers = new List<int> { 1, 2 , 3 };

        public static int TotalWithLoops()
        {
            var total = 0;

            foreach (var number in numbers)
            {
                total += number;
            }

            return total;
        }

        public static int TotalWithLinq()
        {
            return numbers.Aggregate(0, (a, b) => a + b);
        }
    }
}
