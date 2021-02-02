using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Equal = calculator.AreEqual<int>(10 , 10);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    //public class calculator<T> Also we can create Class as Generics
    public class calculator
    {
        //public static bool AreEqual(int Value1, int Value2)
        //{
        //    return Value1 == Value2;
        //}

        //public static bool AreEqual(object Value1, object Value2)
        //{
        //    return Value1 == Value2;
        //}

        public static bool AreEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
