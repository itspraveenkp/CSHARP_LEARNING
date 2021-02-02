using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a Number ");
        int number = int.Parse(Console.ReadLine());

        #region IF statement

        //if (number == 10)
        //{
        //    Console.WriteLine("Your Number is 10");
        //}
        //else if (number == 20)
        //{
        //    Console.WriteLine("Your Number is 20");
        //}
        //else if (number == 30)
        //{
        //    Console.WriteLine("Your Number is 30");
        //}
        //else
        //{
        //    Console.WriteLine("Your have entered wrong Number ");
        //}
        #endregion

        switch (number)
        {
            #region we can write as well as like below statement
            //case 10:
            //    Console.WriteLine("Your number is 10");
            //    break;
            //case 20:
            //    Console.WriteLine("Your number is 20");
            //    break;
            //case 30:
            //    Console.WriteLine("Your number is 30");
            //    break;
            #endregion

            case 10:
            case 20:
            case 30:
                Console.WriteLine("Your numer is {0}", number);
                break;
            default:
                Console.WriteLine("your have entered wrong values");
                break;
        }
        Console.ReadKey();
    }
}

