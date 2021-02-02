using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_instance_class_members
{
    class Circle
    {
        static float _Pi;
        //float _Pi = 3.141f;
        int _radius;

        //public static Circle()
        //{
        //    //static Constructor does not allow to access Modifier.
        //}

        static Circle()
        {
           Circle._Pi = 3.141f;
        }

        public Circle(int Radius)
        {
            this._radius = Radius;
        }

        public float CalculateAre()
        {
            //return this._Pi * this._radius * this._radius;
            return Circle._Pi * this._radius * this._radius;
        }

        //public static void Print()
        //{
        //    //Code
        //}

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Circle c1 = new Circle(5);
            float Area = c1.CalculateAre();
            Console.WriteLine("Area = {0}",Area);

            Circle c2 = new Circle(6);
            float Area2 = c2.CalculateAre();
            Console.WriteLine("Area2 = {0}", Area2);

            //Circle.Print();

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            Console.ReadKey();
 
        }
    }
}
