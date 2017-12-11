using System;
using System.Linq;

namespace FunctionalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Select
            var loopSelect = Select.ToUpperWithLoops();
            loopSelect.ToList().ForEach(Console.WriteLine);

            var linqSelect = Select.ToUpperWithLinq();
            linqSelect.ToList().ForEach(Console.WriteLine);

            //Where
            var loopWhere = Where.LessThan50WithLoops();
            loopWhere.ToList().ForEach(Console.WriteLine);

            var linqWhere = Where.LessThan50WithLinq();
            linqWhere.ToList().ForEach(Console.WriteLine);

            //Aggregate and Reduce
            var loopAggregate = Aggregate.TotalWithLoops();
            Console.WriteLine(loopAggregate);

            var linqAggregate = Aggregate.TotalWithLoops();
            Console.WriteLine(linqAggregate);
        }
    }
}
