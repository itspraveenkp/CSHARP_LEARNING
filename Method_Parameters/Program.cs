using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //Program.Event(ref i);
            //Console.WriteLine(i);

            //int total = 0;
            //int product = 0;
            //Caculate(10, 20, out total, out product);
            //Console.WriteLine("Sum ={0} && Product ={1}",total,product);
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            ParamersMethod(numbers);

            Console.ReadKey();
        }

        //public static void Event(ref int j)
        //{
        //    j = 12;
        //}

        //public static void Caculate(int fn, int sn,out int sum, out int product)
        //{
        //    sum = fn + sn;
        //    product = fn * sn;
        //}

        public static void ParamersMethod(params int[] Array)
        {
            Console.WriteLine("There are {0} element",Array.Length);
            foreach (int j in Array)
            {
                Console.WriteLine(j);
            }
        }
    }
}
