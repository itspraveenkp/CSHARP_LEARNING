using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> listemployees = new List<Employee>()
            {
                new Employee{ ID= 101, Name ="Mark"},
                new Employee{ ID = 102, Name = "Sam"},
                new Employee{ ID=103, Name="Mary"},
            };

            //step 2
            //Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);

            //step 3

            //Employee employee = listemployees.Find(emp => FindEmployee(emp));
            //Console.WriteLine("Employee ID = {0}, Name = {1} ",  employee.ID,employee.Name);

            Employee employee = listemployees.Find(delegate(Employee emp)
            {
                return emp.ID == 102;
            });
            Console.WriteLine("Employee ID = {0}, Name = {1} ", employee.ID, employee.Name);

            Console.ReadKey();
        }

        //step one
        //public static bool FindEmployee(Employee emp)
        //{
        //    return emp.ID == 102;
        //}
    }

    public class Employee
    {
        public int ID { get; set; }
        public string  Name { get; set; }
    }
}
