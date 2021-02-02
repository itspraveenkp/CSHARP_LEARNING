using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter your choice number :");
        int number =int.Parse(Console.ReadLine());
        int choise = 0;
        while (choise <= number)
        {
            Console.WriteLine(choise + " ");
            choise = choise + 2;
        }
        Console.ReadKey();
    }
}

