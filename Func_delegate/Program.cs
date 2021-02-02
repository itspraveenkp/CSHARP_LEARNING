using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listemployees = new List<Employee>()
            {
                new Employee{ ID= 101, Name="Mark"},
                new Employee{ ID=102, Name= "Praveen"},
                new Employee{ ID=103, Name="Sanny"},
            };

            //Func<Employee, string> selector = employee => "Name = " + employee.Name;
            IEnumerable<string> names = listemployees.Select(employee => "Name = " + employee.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string  Name { get; set; }
    }
}
