using System;
using System.Collections.Generic;
namespace Delegates_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experince = 5 });
            emplist.Add(new Employee() { ID = 102, Name = "cary", Salary = 6000, Experince = 6 });
            emplist.Add(new Employee() { ID = 103, Name = "sary", Salary = 7000, Experince = 7 });
            emplist.Add(new Employee() { ID = 104, Name = "pary", Salary = 8000, Experince = 8 });
            emplist.Add(new Employee() { ID = 105, Name = "bary", Salary = 4000, Experince = 3 });
            emplist.Add(new Employee() { ID = 106, Name = "nary", Salary = 6000, Experince = 9 });
            emplist.Add(new Employee() { ID = 107, Name = "Hary", Salary = 2000, Experince = 2 });
            //Employee.PromoteEmployee(emplist);
            IsPromotable isPromotable = new IsPromotable(IsPromote);

            Employee.PromoteEmployee(emplist, isPromotable);
            Employee.PromoteEmployee(emplist, emp => emp.Experince >= 5); //We can use lemda expression


            Console.ReadKey();
        }

        public static bool IsPromote(Employee emp)
        {
            if (emp.Experince >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    delegate bool IsPromotable(Employee empl); 

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experince { get; set; }

        public static void PromoteEmployee(List<Employee> employeesList, IsPromotable IsEligibleToPromate)
        {
            foreach (Employee employee in employeesList)
            {

                if (IsEligibleToPromate(employee))
                {
                    Console.WriteLine(employee.Name + "Pramoted");
                }
                //if (employee.Experince >= 5 )
                //{
                //    Console.WriteLine(employee.Name + "Pramoted");
                //}
            }
        }
    }
}
