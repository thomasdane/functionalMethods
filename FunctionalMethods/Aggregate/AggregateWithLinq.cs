using System.Collections.Generic;
using System.Linq;

namespace FunctionalMethodsCsharp.Aggregate
{
    public static class AggregateWithLinq
    {
        private static readonly List<int> numbers = new List<int> { 1, 2 , 3 };

        public static int Total()
        {
            return numbers.Aggregate(0, (a, b) => a + b);
        }
    }
}
