using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Passing_data_to_the_Thread_function
{
    public delegate void SumOfNumbersCallBack(int SumOfNumbers);
    class Program
    {
        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum of Number : ", + sum);
        }

        static void Main(string[] args)
        {
            Console.Write("Please Enter target Number : ");
            int target = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallBack callBack = new SumOfNumbersCallBack(PrintSum);

            Number number = new Number(target, callBack);
            Thread thread = new Thread(new ThreadStart(number.PrintSumOfNumbers));
            thread.Start();
            Console.ReadKey();
        }
    }

    class Number
    {
        int _target;
        SumOfNumbersCallBack _CallBackMethod;
        public Number(int target, SumOfNumbersCallBack CallBackMethod)
        {
            this._target = target;
            this._CallBackMethod = CallBackMethod;
        }

        public void PrintSumOfNumbers()
        {
            int sum = 0;

            for (int i = 1; i <= _target; i++)
            {
                sum = sum + 1;
            }
            if (_CallBackMethod != null)
            {
                _CallBackMethod(sum);
            }
        }
    }
}
