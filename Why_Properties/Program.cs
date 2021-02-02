using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_Properties
{
    public class Student
    {
        //public int ID;
        //public string Name;
        //public int PassMark = 35;

        private int _id;
        private string _Name;
        private int _passMark = 35;

        public void SetID(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Student id can not be negative");
            }
            this._id = id;
        }

        public int Getid()
        {
            return this._id;
        }

        public void SetName(string Name)
        {
            if(string.IsNullOrEmpty(Name))
            {
                throw new Exception("Student id cannot be null");
            }
            this._Name = Name;
        }

        public string GetName()
        {
            if (string.IsNullOrEmpty(this._Name))
            {
                return "No Name";
            }
            else
            {
                return this._Name;
            }

            //Or We can use ternary operator
            //return (string.IsNullOrEmpty(this._Name)) ? "No Name" : this._Name;

        }

        #region No need to set. Already Set

        //public void SetPassmark(int passmark)
        //{
        //    if (passmark == 0)
        //    {
        //        throw new Exception("Passmark cannot be Zero");
        //    }
        //    this._passMark = passmark;
        //}
        #endregion

        public int GetPassmark()
        {
            return this._passMark;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //s1.ID = -101;
            //s1.Name = null;
            //s1.PassMark = 0;

            //Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}",s1.ID,s1.Name,s1.PassMark);

            Student s1 = new Student();
            s1.SetID(100);

            Console.WriteLine("Student Id = {0}",s1.Getid());

            Student s2 = new Student();
            s2.SetName("Praveen");

            Console.WriteLine("Student Name = {0}", s2.GetName());

            Student s3 = new Student();
            

            Console.WriteLine("Student Passmark = {0}",s3.GetPassmark());

            Console.ReadKey();
        }
    }
}
