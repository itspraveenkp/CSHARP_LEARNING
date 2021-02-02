using System;

class Program
{
    static void Main()
    {
        //WeakReference can convert int to flote but we can not convert float to int
        //int i = 100;
        //float f = i;

        //Console.WriteLine(f);

        //so for convert add  user convert.int32
        //float f = 100;
        //int i = (int)f; in this case mightbe we lost data

        float f = 100.45f;
        int i = Convert.ToInt32(f);
        Console.WriteLine(f);

        Console.WriteLine(f);

        Console.ReadKey();
    }
}
