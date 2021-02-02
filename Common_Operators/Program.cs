using System;

class Program
{
    static void Main()
    {
        int number = 10;
        int anothernumber = 20;

        if (number == 11 || anothernumber == 21)
        {
            Console.WriteLine("Hello OR");
        }
        // if one condition not matching than will print Hello or
        else if (number == 11 || anothernumber == 21)
        {
            Console.WriteLine("Hello OR");
        }

        // if both condition not matching than will print else statement
        else if (number == 11 || anothernumber == 21)
        {
            Console.WriteLine("Hello OR");
        }
        else
        {
            Console.WriteLine("Chutiya hai kya");
        }

        //if (number == 10 && anothernumber == 20)
        //{
        //    Console.WriteLine("Hello And");
        //}
        if (number == 11 && anothernumber == 20)
        {
            Console.WriteLine("Hello And");
        }

        else
        {
            Console.WriteLine("Nahi match huaa");
        }
        Console.ReadKey();
    }
}

