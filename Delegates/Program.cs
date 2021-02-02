using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void HelloFuntionDelegate(string Message);
    class Program
    {
        static void Main(string[] args)
        {
            HelloFuntionDelegate helloFuntionDelegate = new HelloFuntionDelegate(Hello);
            helloFuntionDelegate("Hello From Deltegate");
            
            //Delegate is a type safe function pointer
            Console.ReadKey();
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
