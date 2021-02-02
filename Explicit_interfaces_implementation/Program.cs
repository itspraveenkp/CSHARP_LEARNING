using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_interfaces_implementation
{
    interface I1
    {
        void Interfacemethod();
    }
    interface I2
    {
        void Interfacemethod();
    }

    class Program : I1,I2
    {
        //Implecit Interface
        //public void Interfacemethod()
        //{
        //    Console.WriteLine("I1 Interface Method");
        //}

       //Explicit Interface
        void I1.Interfacemethod()
        {
            Console.WriteLine("I1 Interface Method");
        }

        void I2.Interfacemethod()
        {
            Console.WriteLine("I2 Interface Method");
        }

        static void Main(string[] args)
        {
            Program P1 = new Program();
            //P1.Interfacemethod(); in Implecit interface you can not call like this
            ((I1)P1).Interfacemethod();
            ((I2)P1).Interfacemethod();

            I1 i1 = new Program();
            I2 i2 = new Program();
            i1.Interfacemethod();
            i2.Interfacemethod();

            Console.ReadKey();
        }
    }
}
