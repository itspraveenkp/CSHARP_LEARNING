using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            CorporateCustomer c1 = new CorporateCustomer();
            c1.PrintID();
            Console.ReadKey();
        }
    }

    //public class Customer
    //{
    //    private int _id; //Private member only can access in same class, can not access in anthor class

    //    public int ID
    //    {
    //        get { return _id; }
    //        set { _id = value; }
    //    }
    //}

    public class Customer
    {
        protected int _id;

    }

    public class CorporateCustomer : Customer
    {
        public void PrintID()
        {
            CorporateCustomer cc = new CorporateCustomer();
            cc._id = 101;
            Console.WriteLine(cc._id);
        }
    }
}
