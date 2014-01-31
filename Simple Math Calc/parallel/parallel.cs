using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace parallel
{
    class parallel
    {
        static void Main(string[] args)
        {
            var clock = Stopwatch.StartNew();
            Parallel.For(2, 10, (i) =>
            {
                var result = CalcMath(i);
                Console.WriteLine("node {0} : {1}", i, result);
            });
            Console.WriteLine(clock.ElapsedMilliseconds);
            Console.ReadLine();
        }

        public static double CalcMath(int root)
        {
            double result = 0;
            for (int i = 1; i < 1000000; i++ )
            {
                result += Math.Pow(6, 10) + 509;
            }
            return result;
        }    
    }
}
