using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_parameters_optional_using_method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumber(10, 20);
            AddNumber(10,20,new int[] { 30,70});

            Test(20, c: 2);
            Console.ReadKey();
        }

        public static void AddNumber(int FirstNumber, int SecondNumbar, int[] restofNumber = null)
        {
            int result = FirstNumber + SecondNumbar;


            if (restofNumber != null)
            {
                foreach (int i in restofNumber)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum = " + result);
        }

        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("a =" + a);
            Console.WriteLine("b =" + b);
            Console.WriteLine("c =" + c );
        }
    }
}
