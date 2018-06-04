using System;
using System.Linq;

namespace ConsoleApp_集合的運算
{
    class Program
    {
        static void Main(string[] args)
        {
            //Union/Intersect/Except
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var unionResults = numbersA.Union(numbersB);
            var intersectResults = numbersA.Intersect(numbersB);
            var exceptResults = numbersA.Except(numbersB);

            Console.WriteLine("== Union ==");

            foreach(var q in unionResults)
            {
                Console.Write(q + " ");
            }

            Console.WriteLine();
            Console.WriteLine("== Intersect ==");

            foreach(var q in intersectResults)
            {
                Console.Write(q + " ");
            }

            Console.WriteLine();
            Console.WriteLine("== Except ==");

            foreach(var q in exceptResults)
            {
                Console.Write(q + " ");
            }

            Console.WriteLine();

            // distinct
            int[] numberSeries = { 2, 2, 3, 5, 5 };
            var distinctValues = numberSeries.Distinct();

            Console.WriteLine("Distinc values from numberSeries");

            foreach( var q in distinctValues)
            {
                Console.Write(q + " ");
            }

            Console.Read();
        }
    }
}
