using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NuGetCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            var listA = Enumerable.Range(0, 100000);
            var listB = Enumerable.Range(50000, 100000);

            var stopWatch = new Stopwatch();

            // Union operation
            stopWatch.Start();
            var listUniCount = listA.Union(listB).Count();
            Console.WriteLine(listUniCount);
            stopWatch.Stop();
            var unionTicks = stopWatch.ElapsedTicks;

            // Concat operation
            stopWatch.Restart();
            var listConCount = listA.Concat(listB).Count();
            Console.WriteLine(listConCount);
            stopWatch.Stop();
            var concatTicks = stopWatch.ElapsedTicks;

            // Concat and Distinct operations
            stopWatch.Restart();
            var listConDistCount = listA.Concat(listB).Distinct().Count();
            Console.WriteLine(listConDistCount);
            stopWatch.Stop();
            var conDisTicks = stopWatch.ElapsedTicks;

            Console.WriteLine($"Union: {unionTicks}");
            Console.WriteLine($"Concat: {concatTicks}");
            Console.WriteLine($"ConDist: {conDisTicks}");
        }
    }
}
