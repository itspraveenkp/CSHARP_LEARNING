using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            customer c1 = new customer("praveen", "prajapati");
            c1.PrintFull();

            customer c2 = new customer();
            c2.PrintFull();

            Console.ReadKey();
            
        }
    }

    class customer
    {
        string _firstname;
        string _lastname;

        //This is Cunstructore class
        public customer(string FirstName, string LastName)
        {
            this._firstname = FirstName;
            this._lastname = LastName;
        }

        public customer() : this("No Full Name", "No Last Name")
        {

        }

        public void PrintFull()
        {
            Console.WriteLine("FullName = {0} ",_firstname + " " + _lastname);
        }
        
        //This is Destructore Class
        ~customer(){
            //Clean Up Code
        }

    }
}
