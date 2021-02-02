using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _passmark = 35;
        //private string _city;
        //private string _email;

        public int ID
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Student id cannot be negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or Emplty");
                }
                this._Name = value;
            }
            get
            {
                return (string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name); // This is call ternary operator
            }
        }

        public int PassMark
        {
            get
            {
                return this._passmark;
            }
        }

        //public string City
        //{
        //    get
        //    {
        //        return this._city;
        //    }
        //    set
        //    {
        //        this._city = value;
        //    }
        //}

        //public string Email
        //{
        //    get
        //    {
        //        return this._email;
        //    }
        //    set
        //    {
        //        this._email = value;
        //    }
        //}

        //We can write this code in one line
        public string Email { get; set; } // call auto implementted properties
        public string City { get; set; }// call auto implementted properties

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.ID = 101;
            s1.Name = "Ava";

            Console.WriteLine("Student id is = {0}",s1.ID);
            Console.WriteLine("Student Name is = {0}", s1.Name);
            Console.WriteLine("Student PassMark is = {0}", s1.PassMark);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
