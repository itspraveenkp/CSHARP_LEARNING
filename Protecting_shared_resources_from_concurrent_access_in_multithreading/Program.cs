using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Protecting_shared_resources_from_concurrent_access_in_multithreading
{
    class Program
    {
        static int Total = 0;
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Thread T1 = new Thread(Program.AddOneMillion);
            Thread T2 = new Thread(Program.AddOneMillion);
            Thread T3 = new Thread(Program.AddOneMillion);

            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();

            Console.WriteLine("Total = "+ Total);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);

            Console.ReadKey();
        }

        static object _lock = new object();
        public static void AddOneMillion()
        {
            for (int i = 1; i < 1000000; i++)
            {
                //Total++;
                //Interlocked.Increment(ref Total);
                lock (_lock)
                {
                    Total++;
                }
            }
            {

            }
        }
    }
}
