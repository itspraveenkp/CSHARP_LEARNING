using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }

    public class Customer : ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Interface Print1 Method");
        }

        public void Print2()
        {
            Console.WriteLine("Interface Print2 Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer();
            //c1.Print1();
            //c1.Print2();

            //ICustomer1 c1 = new ICustomer1(); you can not do like this
            ICustomer1 cust = new Customer(); // but you can do like this
            cust.Print1();

            Console.ReadKey();
        }
    }
}
