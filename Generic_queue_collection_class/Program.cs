using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_queue_collection_class
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

            Queue<Customer> Queuecustomers = new Queue<Customer>();
            Queuecustomers.Enqueue(customer1);
            Queuecustomers.Enqueue(customer2);
            Queuecustomers.Enqueue(customer3);
            Queuecustomers.Enqueue(customer4);
            Queuecustomers.Enqueue(customer5);

            if (Queuecustomers.Contains(customer1))
            {
                Console.WriteLine("Customer1 Exists");
            }
            else
            {
                Console.WriteLine("Customer1 does not Exists");
            }

            //Customer c = Queuecustomers.Peek();
            //Console.WriteLine(c.ID + "-" + c.Name);
            //Console.WriteLine("Total item in the queue = " + Queuecustomers.Count);


            //foreach (Customer c in Queuecustomers)
            //{
            //    Console.WriteLine(c.ID + "-" + c.Name);
            //    Console.WriteLine("Total item in the queue = " + Queuecustomers.Count);
            //}

            //Customer c2 = Queuecustomers.Dequeue();
            //Console.WriteLine(c2.ID + "-" + c2.Name);
            //Console.WriteLine("item left in the queue = " + Queuecustomers.Count);

            //Customer c3 = Queuecustomers.Dequeue();
            //Console.WriteLine(c3.ID + "-" + c3.Name);
            //Console.WriteLine("item left in the queue = " + Queuecustomers.Count);

            //Customer c4 = Queuecustomers.Dequeue();
            //Console.WriteLine(c4.ID + "-" + c4.Name);
            //Console.WriteLine("item left in the queue = " + Queuecustomers.Count);

            //Customer c5 = Queuecustomers.Dequeue();
            //Console.WriteLine(c5.ID + "-" + c5.Name);
            //Console.WriteLine("item left in the queue = " + Queuecustomers.Count);


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
