using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA =  ProjectA.TeamA;
using PATB = ProjectA.TeamB;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProjectA.TeamA.print();
            //ProjectA.TeamB.print();

            //PATA.print();
            //PATB.print();

            //Read From Class Library
            PATA.ClassA.print();
            PATB.ClassA.print();


            Console.ReadKey();
        }
    }
}

//namespace ProjectA
//{
//    class TeamA
//    {
//        public static void print()
//        {
//            Console.WriteLine("Hello from Team A");
//        }
//    }
//}

//namespace ProjectA
//{
//    class TeamB
//    {
//        public static void print()
//        {
//            Console.WriteLine("Hello From Team B");
//        }
//    }
//}
