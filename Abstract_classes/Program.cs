using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    public abstract class Customer
    {
        public abstract void Print();

        public void Print1()
        {
            Console.WriteLine("Print Method Direct from abstract class instance");
        }

    }

    public class Program : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print Method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Print();

            Customer c1 = new Program();
            c1.Print();
            c1.Print1();
            
            Console.ReadKey();
        }
    }
}
