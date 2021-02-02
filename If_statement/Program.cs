using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            if (number > 10)
            {
                Console.WriteLine("Grater than 10: Correct");
            }
            else if (number < 10)
            {
                Console.WriteLine("less than 10:Correct");
            }
            else
            {
                Console.WriteLine("Error");
            }
            
            Console.ReadKey();
            }
        }
    }
}
