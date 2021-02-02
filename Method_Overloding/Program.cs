using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloding
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
            
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(float FN, float SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(float FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(int FN, int SN, out int sum)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
            sum = FN + SN;
        }
    }
}
