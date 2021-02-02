using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 45000
            };

            Customer customer1 = new Customer()
            {
                ID = 102,
                Name = "pam",
                Salary = 55000
            };

            Customer customer2 = new Customer()
            {
                ID = 103,
                Name = "john",
                Salary = 40000
            };

            Customer[] customers = new Customer[3];
            customers[0] = customer;
            customers[1] = customer1;
            customers[2] = customer2;

            Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

            foreach (KeyValuePair<int, Customer> kvp in dict)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID,cust.Name,cust.Salary);
            }

            //List<Customer> lcustomers = new List<Customer>();
            //lcustomers.Add(customer);
            //lcustomers.Add(customer1);
            //lcustomers.Add(customer2);

            //Dictionary<int, Customer> ldict = customers.ToDictionary(cust => cust.ID, cust => cust);

            //foreach (KeyValuePair<int, Customer> kvp in ldict)
            //{
            //    Console.WriteLine("Key = {0}", kvp.Key);
            //    Customer cust = kvp.Value;
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //}

            //Dictionary<int, Customer> dictionaryCustomer = new Dictionary<int, Customer>();

            //dictionaryCustomer.Add(customer1.ID, customer1);
            //dictionaryCustomer.Add(customer2.ID, customer2);
            //dictionaryCustomer.Add(customer.ID, customer);

            //Console.WriteLine("Total Count = {0}", dictionaryCustomer.Count);
            //Console.WriteLine("Total Count = {0}", dictionaryCustomer.Count(kvp => kvp.Value.Salary > 40000));

            //dictionaryCustomer.Remove(101);
            //dictionaryCustomer.Clear();

            //Customer cust;
            //if (dictionaryCustomer.TryGetValue(101, out cust))
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("Key is not found..!");
            //}

            //Customer customer103 = dictionaryCustomer[103];

            //Console.WriteLine("ID {0}, Name = {1}, Salary = {2}", customer103.ID, customer103.Name, customer103.Salary + "<br />");

            //foreach (var CustomerKeyPair in dictionaryCustomer)

            //foreach (KeyValuePair<int, Customer> CustomerKeyPair in dictionaryCustomer)
            // {
            //     Console.WriteLine("Key = {0}", CustomerKeyPair.Key);
            //     Customer cust = CustomerKeyPair.Value;
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID,cust.Name,cust.Salary);

            //     Console.WriteLine("--------------------------------------------------------------------");
            // }

            //foreach (int Key in dictionaryCustomer.Keys)
            //{
            //    Console.WriteLine("Key = {0}", Key);
            //    Console.WriteLine("--------------------------------------------------------------------");
            //}

            //foreach (Customer CustValue in dictionaryCustomer.Values)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",CustValue.ID, CustValue.Name, CustValue.Salary);
            //    Console.WriteLine("--------------------------------------------------------------------");
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
