using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_Enums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer()
            {
                Name = "Mark",
                Gender = 1
            };

            customers[1] = new Customer()
            {
                Name = "Sam",
                Gender = 0
            };

            customers[2] = new Customer()
            {
                Name = "selina",
                Gender = 2
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender ={1}",customer.Name,GetGender(customer.Gender));
            }


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public static string GetGender(int gender)
        {
            switch (gender)
            {

                case 0:
                    return "Unknown";
                    
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data for Gender"; 
            }
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}
