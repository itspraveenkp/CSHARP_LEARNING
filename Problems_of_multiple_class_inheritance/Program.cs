using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_of_multiple_class_inheritance
{
    class A
    {
        public virtual  void Print()
        {
            Console.WriteLine("Hello From A Print Method");
        }
    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("Hello From B Print Method");
        }
    }
    class C : B
    {
        public override void Print()
        {
            Console.WriteLine("Hello From B Print Method");
        }
    }

    //class D : C,B
    //{
    //    // We can not inherit class more then one
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //B b = new B();
            //b.Print();

            A b = new B();
            b.Print();


            A a = new A();
            a.Print();
            Console.ReadKey();
        }
    }
}
