using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Lambda_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listemployees = new List<Employee>()
            {
                new Employee{ ID = 101, Name="Praveen"},
                new Employee{ ID = 102, Name="sam"},
                new Employee{ ID = 103, Name="Able"},
                new Employee{ ID = 104, Name="Mark"},
            };

            Predicate<Employee> predicateemployee = new Predicate<Employee>(FindEmployee);

            //Employee employee = listemployees.Find(emp => emp.ID == 102);
            Employee employee = listemployees.Find((Employee emp) => emp.ID == 102);

            Console.WriteLine("ID = {0}, Name = {1}", employee.ID,employee.Name);

            int count = listemployees.Count(x => x.Name.StartsWith("P"));
            Console.WriteLine("Count " + count);

            Console.ReadKey();
        }

        public static bool FindEmployee(Employee emp)
        {
            return emp.ID == 102;
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
