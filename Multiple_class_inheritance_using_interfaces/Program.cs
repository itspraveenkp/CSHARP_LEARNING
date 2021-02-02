using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_class_inheritance_using_interfaces
{
    interface IA
    {
        void APrint();
    }

    class A : IA
    {
        public void APrint()
        {
            Console.WriteLine("A");
        }
    }

    interface IB
    {
        void BPrint();
    }

    class B : IB
    {
        public void BPrint()
        {
            Console.WriteLine("B");
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void APrint()
        {
            a.APrint();
        }

        public void BPrint()
        {
            b.BPrint();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.APrint();
            ab.BPrint();
            Console.ReadKey();
        }
    }
}
