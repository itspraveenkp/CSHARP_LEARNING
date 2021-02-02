using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Significance_of_Thread_Join_and_Thread_IsAlive_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started");
            Thread T1 = new Thread(Program.Thread1Function);
            T1.Start();
            Thread T2 = new Thread(Program.Thread2Function);
            T2.Start();

            if (T1.Join(1000))
            {
                Console.WriteLine("Thread1Function Completed");
            }
            else
            {
                Console.WriteLine("Thread1Function has not completed in 1 sec");
            }

            T2.Join();
            Console.WriteLine("Thread2Function Completed");
            for (int i = 0; i <= 10; i++)
            { 
            
                if (T1.IsAlive)
                {
                    Console.WriteLine("Thread1Function is still doing it's Work");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("Thread1Function Completed");
                    break;
                }
            }
            Console.WriteLine("Main Function Completed");


            Console.ReadKey();
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function Started");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1Function About to return");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function Started");
        }
    }
}
