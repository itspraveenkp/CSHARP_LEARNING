using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates
{
    //public delegate void SampleDelegate();
    //public delegate int IntSampleDelegate();
    public delegate void OutputParaSampleDelegate(out int Integer);
    class Program
    {
        static void Main(string[] args)
        {

            //SampleDelegate del = new SampleDelegate(SampleMethodOne);
            //del();

            //SampleDelegate del1, del2, del3,del4;
            //del1 = new SampleDelegate(SampleMethodOne);
            //del2 = new SampleDelegate(SampleMethodtwo);
            //del3 = new SampleDelegate(SampleMethodThree);

            //del1();
            //del2();
            //del3();

            //del4 = del1 + del2 + del3;
            //del4 = del1 + del2 + del3 - del2;
            //del4();

            //SampleDelegate del = new SampleDelegate(SampleMethodOne);
            //del += SampleMethodThree;
            //del += SampleMethodtwo;
            //del -= SampleMethodtwo;
            //del();

            //IntSampleDelegate del = new IntSampleDelegate(SampleMethodOne);
            //del += SampleMethodtwo;
            //int DelegateReturnedValue =  del();
            //Console.WriteLine("DelegateReturnedValue ={0}", DelegateReturnedValue);

            OutputParaSampleDelegate del = new OutputParaSampleDelegate(SampleMethodOne);
            del += SampleMethodtwo;
            int OutputParameterValue = -1;
            del(out OutputParameterValue);

            Console.WriteLine("OutputParameterValue = {0}", OutputParameterValue);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        //public static void SampleMethodOne()
        //{
        //    Console.WriteLine("SampleMethodOne Invoked");
        //}

        //public static void SampleMethodtwo()
        //{
        //    Console.WriteLine("SampleMethodtwo Invoked");
        //}

        //public static void SampleMethodThree()
        //{
        //    Console.WriteLine("SampleMethodThree Invoked");
        //}

        //public static int SampleMethodOne()
        //{
        //    return 1;
        //}

        //public static int SampleMethodtwo()
        //{
        //    return 2;
        //}

        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }

        public static void SampleMethodtwo(out int Number)
        {
            Number = 2;
        }
    }



}
