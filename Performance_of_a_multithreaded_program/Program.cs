using System;
using System.Threading;
using System.Diagnostics;

namespace Performance_of_a_multithreaded_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread T1 = new Thread(Program.EvenNumberSum);
            Thread T2 = new Thread(Program.OddNumberSum);

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();

            stopwatch.Stop();
            Console.WriteLine("Total milliseconds with multiple threads = " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine();

            stopwatch = Stopwatch.StartNew();
            EvenNumberSum();
            OddNumberSum();
            stopwatch.Stop();
            Console.WriteLine("Total milliseconds without multiple threads = " + stopwatch.ElapsedMilliseconds);

            Console.ReadKey();
        }

        public static void EvenNumberSum()
        {
            double sum = 0;
            for (int i = 0; i <= 50000000; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of Event Numbers = {0}", sum);
        }

        public static void OddNumberSum()
        {
            double sum = 0;
            for (int i = 0; i <= 50000000; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + 1;
                }
            }
            Console.WriteLine("Sum of Odd Numbers = {0}", sum);
        }
    }
}
