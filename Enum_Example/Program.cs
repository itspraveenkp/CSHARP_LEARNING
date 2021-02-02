using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer()
            {
                Name = "Mark",
                Gender = Gender.Male
            };

            customers[1] = new Customer()
            {
                Name = "Sam",
                Gender = Gender.Unknown
            };

            customers[2] = new Customer()
            {
                Name = "selina",
                Gender = Gender.Female
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender ={1}", customer.Name, GetGender(customer.Gender));
            }


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public static string GetGender(Gender gender)
        {
            switch (gender)
            {

                case Gender.Unknown:
                    return "Unknown";

                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data for Gender";
            }
        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
