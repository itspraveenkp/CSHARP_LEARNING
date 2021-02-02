using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string userchoice = string.Empty;
            do
            {
                Console.Write("Please Emter your target ");
                int usertarget = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= usertarget)
                {
                    Console.WriteLine(start);
                    start = start + 2;
                }
                do
                {
                    Console.Write("Do you want to set target again then Please Enter Yes or No? ");
                    userchoice = Console.ReadLine().ToUpper();

                    if (userchoice != "YES" && userchoice != "NO")
                    {
                        Console.WriteLine("your choice is {0} Invalid, Please Enter Yes Or No? ", userchoice);
                    }
                } while (userchoice != "YES" && userchoice != "NO");
            } while (userchoice == "YES");
            
            Console.ReadKey();
        }
    }
}