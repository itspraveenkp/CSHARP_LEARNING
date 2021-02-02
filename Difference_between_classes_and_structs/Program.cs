using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_between_classes_and_structs
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name{get; set;}

    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            if (i == 10)
            {
                int j = 20;
                Customer c1 = new Customer();
                c1.ID = 101;
                c1.Name = "John";

            }
            Console.ReadKey();
            
        }
    }
}
