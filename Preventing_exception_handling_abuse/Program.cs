using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preventing_exception_handling_abuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter Numerator: ");
                int Numerator;
                bool IsValidNumerator =  int.TryParse(Console.ReadLine(), out Numerator);

                if (IsValidNumerator)
                {
                    Console.WriteLine("Please Enter Denominator");
                    int Denominator;

                    bool IsValidDenominator = int.TryParse(Console.ReadLine(), out Denominator);

                    if (IsValidDenominator && Denominator != 0)
                    {
                        int result = Numerator / Denominator;
                        Console.WriteLine("Result ={0}",result);
                    }
                    else
                    {
                        if (IsValidDenominator && Denominator == 0)
                        {
                            Console.WriteLine("Denominator can not be Zero");
                        }
                        else
                        {
                            Console.WriteLine("Only Allow Numbers Between min ={0} and max ={1}", Int32.MinValue, Int32.MaxValue);
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("Only Allow Numbers Between min ={0} and max ={1}", Int32.MinValue, Int32.MaxValue);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
