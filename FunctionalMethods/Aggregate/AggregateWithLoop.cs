using System.Collections.Generic;

namespace FunctionalMethodsCsharp.Aggregate
{
    public static class AggregateWithLoop
    {
        private static readonly List<int> numbers = new List<int> { 1, 2 , 3 };

        public static int Total()
        {
            var total = 0;

            foreach (var number in numbers)
            {
                total += number;
            }

            return total;
        }
    }
}
