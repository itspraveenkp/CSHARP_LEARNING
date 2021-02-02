using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {

            AddMembers(10, 20,40,30,60);

            AddMembers(10, 20, new object[] { 40, 30, 60 });
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public static void AddMembers(int FirstNumber, int SecondNumber, params object[] restofNumbers)
        {
            int result = FirstNumber + SecondNumber;
            if (restofNumbers != null)
            {
                foreach (int i in restofNumbers)
                {
                    result += i ;
                }
            }

            Console.WriteLine("Sum = " + result);
        }
    }
}
