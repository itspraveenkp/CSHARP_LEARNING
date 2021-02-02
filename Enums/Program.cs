using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] values = (short[])Enum.GetValues(typeof(Gender));

            foreach (short value in values)
            {
                Console.WriteLine(value);
            }

            string[] Names = Enum.GetNames(typeof(Gender));

            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }

            //Gender gender =(Gender)Season.spring;
            //Console.WriteLine(gender);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    public enum Gender : short
    {
        Unknown = 1,
        Male,
        Female
    }

    public enum Season
    {
        Summmer,
        winter,
        spring 
    }
}
