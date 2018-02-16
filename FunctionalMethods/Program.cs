using System;
using System.Linq;
using FunctionalMethods.Select;
using FunctionalMethodsCsharp.Aggregate;
using FunctionalMethodsCsharp.Select;
using FunctionalMethodsCsharp.Where;

namespace FunctionalMethodsCsharp
{
    internal class Program
    {
        private static void Main()
        {
            //Select/Map
            var loopSelect = SelectWithLoop.ToUpper();
            loopSelect.ToList().ForEach(Console.WriteLine);

            var linqSelect = SelectWithLinq.ToUpper();
            linqSelect.ToList().ForEach(Console.WriteLine);

            ////Where/Filter
            //var loopWhere = WhereWithLoop.LessThan50();
            //loopWhere.ToList().ForEach(Console.WriteLine);

            //var linqWhere = WhereWithLoop.LessThan50();
            //linqWhere.ToList().ForEach(Console.WriteLine);

            ////Aggregate/Reduce
            //var loopAggregate = AggregateWithLoop.Total();
            //Console.WriteLine(loopAggregate);

            //var linqAggregate = AggregateWithLinq.Total();
            //Console.WriteLine(linqAggregate);

            Console.ReadKey();
        }
    }
}
