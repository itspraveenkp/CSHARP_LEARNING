using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloding_and_Method_Hiding
{
    public  class baseclass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am base class print Method");
        }
    }

    //public class SDerivedclass : baseclass
    //{
    //    public new void Print()
    //    {
    //        Console.WriteLine("I am Second Drived class print Method");
    //    }
    //}

    public class Derivedclass : baseclass
    {
        public override void Print()
        {
            Console.WriteLine("I am Drived class print Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            baseclass b = new Derivedclass();
            b.Print();
            Console.ReadKey();
            
        }
    }
}
