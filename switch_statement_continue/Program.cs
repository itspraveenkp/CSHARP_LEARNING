using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statement_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            startgain:
            Console.WriteLine("Please Select Coffee: 1 -Small, 2 -Medium, 3 -Large");
            int userchoice = int.Parse(Console.ReadLine());

            int TotalCoffeeCost = 0;

            switch (userchoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;
                case 2:
                    TotalCoffeeCost += 2;
                    break;
                case 3:
                    TotalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("you choice {0} is invalid",userchoice);
                    goto startgain;
            }

            Decide:
            Console.WriteLine("Do want to buy another coffee - Yes or No?");
            string Userdecision = Console.ReadLine();

            switch(Userdecision.ToUpper())
            {
                case "YES":
                    goto startgain;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Please enter valid Value {0}",Userdecision);
                    goto Decide;
            }

            Console.WriteLine("Thank you for shopping with us..!");
            Console.WriteLine("Your Bill Amount is = {0}", TotalCoffeeCost);

            Console.ReadKey();
        }
    }
}
