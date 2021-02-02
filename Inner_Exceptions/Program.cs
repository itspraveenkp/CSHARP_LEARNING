using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inner_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    int result = num1 / num2;

                    Console.WriteLine("Result = {0}", result);
                }
                catch (Exception ex)
                {
                    //string filepath = @"C:\Users\itspr\source\repos\CSharp_Learning\Inner_Exceptions\Log.txt";
                    string filepath = @"C:\Users\itspr\source\repos\CSharp_Learning\Inner_Exceptions\Log1.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter streamWriter = new StreamWriter(filepath);
                        streamWriter.Write(ex.GetType().Name);
                        streamWriter.Write(ex.Message);
                        Console.WriteLine("There is problem please try again");
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + "is not available", ex);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Current Exception ={0}",exception.GetType().Name);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception ={0}", exception.InnerException.GetType().Name);
                }
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
