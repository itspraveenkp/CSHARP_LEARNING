using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_should_you_override_ToString_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine(number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Praveen";
            C1.LastName = "Prajapati";

            //Console.WriteLine(C1.ToString());
            Console.WriteLine(Convert.ToString(C1));

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.LastName + ", " + FirstName;
        }
    }
}
