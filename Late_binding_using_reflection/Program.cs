using System;
using System.Reflection;

namespace Late_binding_using_reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //Early Bind
            //    Customer c1 = new Customer();
            //    string FullName = c1.GetFullName("Praveen", "Prajapati");
            //    Console.WriteLine("Full Name = {0}",FullName);
            //    Console.ReadKey();

            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType("Late_binding_using_reflection.Customer");
            object customerInstance =  Activator.CreateInstance(customerType);
            MethodInfo getFullName = customerType.GetMethod("GetFullName");
            string[] parameters = new string[2];
            parameters[0] = "Praveen";
            parameters[1] = "Prajapati";

            string fullName = (string)getFullName.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name = {0}",fullName);

            Console.ReadKey();
        }
    }

    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
