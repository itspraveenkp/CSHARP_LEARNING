using System;

    class Program
    {
        static void Main()
        {

        //Built -in types in C#
        //    1.Boolean type – Only true or false
        //    2.Integral Types - sbyte, byte, short, ushort, int, uint, long, ulong, char
        //    3.Floating Types – float and double
        //    4.Decimal Types
        //    5.String Type

        bool b = true;
        //b = 0; this is wrong. you can defind only c and c++

        int i = 0;
        double d = 123.4376835;
        int id = Convert.ToInt32(123.4376835);

        Console.WriteLine("min value = {0}", int.MinValue);
        Console.WriteLine("Max Value = {0}", int.MaxValue);
        Console.WriteLine("double ={0}",d);
        Console.WriteLine("convert int to double ={0}",id);
        Console.ReadKey();
            
        }
    }
