using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_abuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter Numerator");
                int Numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter Denominator");
                int Denominator = Convert.ToInt32(Console.ReadLine());

                int result = Numerator / Denominator;

                Console.WriteLine("Result = {0}", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter a Numer");

            }
            catch (OverflowException)
            {
                Console.WriteLine("Only Numbers between {0} && {1} are allowed", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator can not be devide by Zero");
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
