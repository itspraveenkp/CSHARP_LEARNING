using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Custom_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is logged in - no deupublicate session allowed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base()
        {
        }
        public UserAlreadyLoggedInException(string message) : base(message)
        {
        }

        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

}
