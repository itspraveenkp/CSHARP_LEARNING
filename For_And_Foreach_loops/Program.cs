using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_And_Foreach_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Number = new int[3];
            Number[0] =101;
            Number[1] =102;
            Number[2] =103;

            foreach (int j in Number)
            {
                Console.WriteLine(j);
            }

            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 1)
            //        continue;
            //    Console.WriteLine(i);
            //    if (i == 10)
            //        break;
            //}

            //#3
            //for (int i = 0; i <=20; i = i+2)
            //{
            //    Console.WriteLine(i);
            //    if (i == 10)
            //        break;
            //}

            //#2
            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //#1
            //int Start = 0;
            //while (Start <= 20)
            //{
            //    Console.WriteLine(Start);
            //    Start = Start + 2;
            //}

            //int[] Start = new int [3];
            //Start[0] = 101;
            //Start[1] = 102;
            //Start[2] = 103;
            //int i = 0;
            //while (i < Start.Length)
            //{
            //    Console.WriteLine(Start[i]);
            //    i++;
            //}
            Console.ReadLine();
        }
    }
}
