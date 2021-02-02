using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace method_parameters_optional_by_specifying_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumber(20, 40);
            AddNumber(20, 40,new int[] {20,300 });
            Console.ReadKey();
        }

        public static void AddNumber(int firstNumber, int secondNumber, [Optional] int[] restofNumber)
        {
            int result = firstNumber + secondNumber;

            if (restofNumber != null)
            { 
                foreach (int i in restofNumber)
                {
                    result += i;
                }
                Console.WriteLine("Total = " + result.ToString());
            }
        }
    }
}
