using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace indexers_used
{
    public class Employee
    {
        //auto Implemented Properties
        public int Employeeid { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> listEmployee;

        public Company()
        {
            listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { Employeeid = 1, Name = "Praveen", Gender = "Male" });
            listEmployee.Add(new Employee() { Employeeid = 2, Name = "Ankita", Gender = "Female" });
            listEmployee.Add(new Employee() { Employeeid = 3, Name = "Deepak", Gender = "Male" });
            listEmployee.Add(new Employee() { Employeeid = 4, Name = "Neetu", Gender = "Female" });
            listEmployee.Add(new Employee() { Employeeid = 5, Name = "Akshay", Gender = "Male" });
            listEmployee.Add(new Employee() { Employeeid = 6, Name = "Neha", Gender = "Female" });
            listEmployee.Add(new Employee() { Employeeid = 7, Name = "Sunil", Gender = "Male" });
            listEmployee.Add(new Employee() { Employeeid = 8, Name = "Parik", Gender = "Male" });
            listEmployee.Add(new Employee() { Employeeid = 9, Name = "Madhuri", Gender = "Female" });
            listEmployee.Add(new Employee() { Employeeid = 10, Name = "Gaurav", Gender = "Male" });
            listEmployee.Add(new Employee() { Employeeid = 11, Name = "Deepa", Gender = "Female" });
            listEmployee.Add(new Employee() { Employeeid = 12, Name = "Suman", Gender = "Female" });
        }

        public string this[int employeeid]
        {
            get
            {
                return listEmployee.FirstOrDefault(emp => emp.Employeeid == employeeid).Name;
            }
            set
            {
                listEmployee.FirstOrDefault(emp => emp.Employeeid == employeeid).Name = value;
            }
        }

        public string this[string Gender]
        {
            get
            {
                return listEmployee.Count(emp => emp.Gender == Gender).ToString();
            }
            set
            {
                foreach (Employee employee in listEmployee)
                {
                    if (employee.Gender == Gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    }
}