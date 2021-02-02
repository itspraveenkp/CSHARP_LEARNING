using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_between_Types_and_Type_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Praveen";
            customer.LastName = "Prajapati";

            Console.WriteLine(customer.FirstName+ " " +customer.LastName);
            
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

   public class Customer
    {
        private int _id;
        private string _firstname;
        private string _lastname;

        public int ID
        {
            get{ return _id;}
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string GetFullName()
        {
            return this._firstname + " " + this._lastname;
        }
    }
}
