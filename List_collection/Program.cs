using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 65000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "pam",
                Salary = 55000
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "john",
                Salary = 40000
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Rajesh",
                Salary = 400000
            };

            //create a list of cutomer
            List<Customer> listcustomers = new List<Customer>();
            listcustomers.Add(customer1);
            listcustomers.Add(customer2);
            //Adding  the element beyond the initial capacity fo the list will not throw an exception.
            listcustomers.Add(customer3);

            // item can be retrive from the list by index. the followiong code will 
            //retrive the first item from the list. list index is ZERO based.

            //Customer cust = listcustomers[0];
            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID,cust.Name,cust.Salary);
            //Console.WriteLine("_________________________________________________");

            // Foreach or for loop can be use for iterate throw all the item in the list 

            //usign for loop
            //for (int i = 0; i <= listcustomers.Count; i++)
            //{
            //    Customer _customer = listcustomers[i];
            //    Customer cust = listcustomers[0];
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", _customer.ID, _customer.Name, _customer.Salary);
            //    Console.WriteLine("_________________________________________________");

            //}

            //Using foreach loop

            //foreach (Customer c in listcustomers)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            //    Console.WriteLine("_____________________________________________________________");
            //}

            ////if you want to insert an item at a specific index location of the list, use Insert() method
            //listcustomers.Insert(1, customer2);
            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", listcustomers[1].ID, listcustomers[2].Name, listcustomers[0].Salary);
            //Console.WriteLine("_____________________________________________________________");

            ////To get the index of specific item in the list use indexof() Method
            //Console.WriteLine("index of Customer3 object in the list = " + listcustomers.IndexOf(customer1));

            //if (listcustomers.Contains(customer2))

            //if (listcustomers.Exists(cust => cust.Name.StartsWith("p")))
            //{
            //    Console.WriteLine("Customer2 object exists in the list");
            //}
            //else
            //{
            //    Console.WriteLine("Customer2 object does not exists in the list");
            //}

            //Customer c = listcustomers.Find(cust => cust.Salary > 50000);
            ////Customer c = listcustomers.FindLast(cust => cust.Salary > 50000);

            //List<Customer> customers = listcustomers.FindAll(cust => cust.Salary > 50000);
            //foreach(Customer c in customers)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID,c.Name,c.Salary);
            //}

            //int index = listcustomers.FindIndex(3, cust => cust.Salary > 55000);
            //int index = listcustomers.FindLastIndex(cust => cust.Salary > 55000);
            //Console.WriteLine("Index = " + index);

            //Customer[] customersArray = new Customer[3];
            //customersArray[0] = customer;
            //customersArray[1] = customer1;
            //customersArray[2] = customer2;

            //List<Customer> listcustomer = customersArray.ToList();
            //foreach(Customer c in listcustomer)
            //{
            //    Console.WriteLine("ID ={0}, Name= {1}, salary = {2}",c.ID,c.Name,c.Salary);
            //}


            List<Customer> listcustomer = new List<Customer>();
            listcustomer.Add(customer1);
            listcustomer.Add(customer2);
            listcustomer.Add(customer3);

            List<Customer> listcorporatecustomers = new List<Customer>();
            listcorporatecustomers.Add(customer4);

            listcustomer.AddRange(listcorporatecustomers);

            List<Customer> lscustomer = listcustomer.GetRange(0, 2);


            foreach (Customer c in lscustomer)
            {
                Console.WriteLine("ID ={0}, Name= {1}, salary = {2}, type = {3}", c.ID, c.Name, c.Salary,c.GetType());
            }

            //Dictionary<int, Customer> dictionary =  listcustomer.ToDictionary(x => x.ID);

            //foreach (KeyValuePair<int, Customer > KVP in dictionary)
            //{
            //    Console.WriteLine("Key = " + KVP.Key);
            //    Customer c = KVP.Value;
            //    Console.WriteLine("ID ={0}, Name= {1}, salary = {2}", c.ID, c.Name, c.Salary);
            //}

            Console.ReadKey();
        }


        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
    }
}
