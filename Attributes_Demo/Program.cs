using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(new List<int> { 10, 30 ,40});
            //Calculator.Add(12, 30, 40);
            Console.ReadKey();
        }
    }

    public class Calculator
    {
        //[Obsolete("Use Add(List<int> Numbers) Method")]
        [ObsoleteAttribute("Use Add(List<int> Numbers) Method")]
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }

        public static int Add(List<int> Numbers)
        {
            int sum = 0;
            foreach (int Number in Numbers)
            {
                sum = sum + Number;
            }
            return sum;
        }
    }
}
