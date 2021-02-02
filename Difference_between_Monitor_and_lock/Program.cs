using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Difference_between_Monitor_and_lock
{
    class Program
    {
        static int Total = 0;
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Thread T1 = new Thread(Program.AddOnMillion);
            Thread T2 = new Thread(Program.AddOnMillion);
            Thread T3 = new Thread(Program.AddOnMillion);

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
        public static void AddOnMillion()
        {
            for (int i = 1; i < 1000000; i++)
            {
                Monitor.Enter(_lock);
                try
                {
                    Total++;
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
                //lock (_lock)
                //{
                //    Total++;
                //}


            }
        }
    }
}
