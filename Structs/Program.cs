using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Customer
    {
        //private Fields
        private int _id;
        private string _name;

        //public Properties
        public int ID
        {
            get{ return this._id; }
            set { this._id = value; }
        }

        public string Name { get => _name; set => _name = value; }

        //Constructor
        public Customer(int ID, string Name)
        {
            this._id = ID;
            this._name = Name;
        }

        //Method
        public void Print()
        {
            Console.WriteLine("ID = {0} && Name = {1} ",this._id,this._name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Name = "Praveen";
            c1.ID = 101;
            c1.Print();

            Customer c2 = new Customer(102,"Mark");
            c2.Print();

            Customer c3 = new Customer
            {
                ID = 101,
                Name = "John"
            };
            c3.Print();


            Console.ReadKey();
            
        }
    }
}
