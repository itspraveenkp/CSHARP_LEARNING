using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_stack_collection_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Sam",
                Gender = "Male"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "rakul",
                Gender = "Female",
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Raj",
                Gender = "Male"
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Sanjan",
                Gender = "Female",
            };
            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Ankiteshri",
                Gender = "Female",
            };

            Stack<Customer> stauckCustomer = new Stack<Customer>();
            stauckCustomer.Push(customer1);
            stauckCustomer.Push(customer2);
            stauckCustomer.Push(customer3);
            stauckCustomer.Push(customer4);
            stauckCustomer.Push(customer5);

            
            //Customer c1 =  stauckCustomer.Pop();
            //Console.WriteLine(c1.ID + "-" + c1.Name);
            //Console.WriteLine("Items left in the stack = " + stauckCustomer.Count);

            foreach(Customer c1 in stauckCustomer)
            {
                Console.WriteLine(c1.ID + "-" + c1.Name);
                Console.WriteLine("Items left in the stack = " + stauckCustomer.Count);
            }

            Console.ReadKey();
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
