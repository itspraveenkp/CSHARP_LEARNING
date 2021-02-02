using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.Event();
            //p.Event(20);

            int stored_Data = Program.Add(20,30);
            Console.WriteLine("the sum is = {0}",stored_Data);

            Console.ReadKey();
        }

        public static int Add(int a,int b)
        {
            return a + b;
        }

        //instance method
        #region Return Type function
        
        //public void Event(int number)
        //{
        //    int start = 0;
        //    while (start <= number)
        //    {
        //        Console.WriteLine(start);
        //        start = start + 1;
        //    }
        //}

        #endregion
        //instance method
        #region Non return Type Function

        //public void Event()
        //{
        //    int start = 0;
        //    while(start <= 20)
        //    {
        //        Console.WriteLine(start);
        //        start = start + 1;
        //    }
        //}
        #endregion
    }
}
