using System.Collections.Generic;
using System.Linq;

namespace FunctionalMethodsCsharp.Where
{
    public static class WhereWithLinq
    {
        private static readonly List<int> numbers = new List<int> { 30, 40, 99 };
    
        public static IEnumerable<int> LessThan50()
        {
            return numbers.Where(number => number < 50);
        }
    }
}
