using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_between_Convert_ToString_and_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            //string CustToString = Convert.ToString(customer);
            string CustToString1 = customer.ToString();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
    public class Customer
    {
        public string Name { get; set; }
    }
}
