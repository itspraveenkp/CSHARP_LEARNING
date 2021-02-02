using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadStart_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread thread = new Thread(new ThreadStart(Number.PrintNumber));
            //Thread thread = new Thread(delegate () { Number.PrintNumber(); });
            //Thread thread = new Thread(()=> Number.PrintNumber() );
            //thread.Start();

            Console.Write("Please Enter target Number : ");
            object target = Console.ReadLine();

            // Create an instance ParameterizedThreadStart delegate
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Number.PrintNumber);
            Thread thread = new Thread(parameterizedThreadStart);
            //Thread thread = new Thread(Number.PrintNumber);
            thread.Start(target);

            Console.ReadKey();
        }

    }

    public class Number
    {
        public static void PrintNumber(object target)
        {
            int number = 0;

            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Press Any Key to Exit");
        }
    }
}
