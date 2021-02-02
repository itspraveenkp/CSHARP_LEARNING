using System;
using System.Text;

namespace Difference_between_String_and_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //string UserString = "C# ";
            //UserString += "Welcome ";
            //UserString += "TO ";
            //UserString += "Coder ";
            //UserString += "World..! ";
            //Console.WriteLine(UserString);

            StringBuilder UserString = new StringBuilder("C# ");
            UserString.Append("Welcome ");
            UserString.Append("TO ");
            UserString.Append("Coder ");
            UserString.Append("World..! ");
            Console.WriteLine(UserString);

            string userstring1 = string.Empty;
            for (int i = 1; i <= 10000; i++)
            {
                userstring1 += i.ToString() + " ";
            }
            Console.WriteLine(userstring1);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
