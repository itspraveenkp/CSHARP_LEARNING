using System;
using System.Reflection;

namespace Reflection_Demo
{
   public class Program
    {
        static void Main(string[] args)
        {

            Type T = Type.GetType("Praveen.Customer");
            Console.WriteLine("Full Name = {0}", T.FullName);
            Console.WriteLine("Just Name = {0}",T.Name);
            Console.WriteLine("just the namespace = {0}", T.Namespace);

            Console.WriteLine("Properties in Customers");

            PropertyInfo[] properties = T.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void PrintID()
        {
            Console.WriteLine("ID = {0}",this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}",this.Name);
        }
    }

}
