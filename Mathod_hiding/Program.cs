using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathod_hiding
{
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " +LastName);
        }

    }

    public class FullTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            //base.PrintFullName();
            Console.WriteLine(FirstName + " " + LastName + "-Contractore");
        }
    }

    public class PartTimeEmployee : Employee
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee FTE = new PartTimeEmployee();

            //FullTimeEmployee FTE = new FullTimeEmployee();

            FTE.FirstName = "Praveen";
            FTE.LastName = "Prajapati";
            FTE.PrintFullName();


            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Chandan";
            PTE.LastName = "Prajapati";
            //PTE.PrintFullName();
            ((Employee)PTE).PrintFullName();


            


            Console.ReadKey();
            
        }
    }
}
