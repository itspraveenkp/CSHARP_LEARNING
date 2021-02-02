using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_a_list_of_simple_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 60000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Sam",
                Salary = 50000
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Pam",
                Salary = 620000
            };

            List<Customer> listcustomers = new List<Customer>(100);

            listcustomers.Add(customer1);
            listcustomers.Add(customer2);
            listcustomers.Add(customer3);

            Console.WriteLine("Capacity before = " + listcustomers.Capacity);
            listcustomers.TrimExcess();
            Console.WriteLine("Capacity After= " + listcustomers.Capacity);

            //IReadOnlyCollection<Customer> readOnlycustomers = listcustomers.AsReadOnly();
            //Console.WriteLine(readOnlycustomers.Count);

            //Console.WriteLine(listcustomers.TrueForAll(x => x.Salary > 5000));

            //Comparison<Customer> customerCompare = new Comparison<Customer>(compareCustomer);

            //Console.WriteLine("Before Sorting");
            //foreach (Customer customer in listcustomers)
            //{
            //    Console.WriteLine(customer.ID);
            //}

            ////listcustomers.Sort(customerCompare);
            ////listcustomers.Sort(delegate (Customer c1, Customer c2) { return c1.ID.CompareTo(c2.ID); });
            //listcustomers.Sort((x, y) => x.ID.CompareTo(y.ID));

            //Console.WriteLine("After Sorting");
            //foreach (Customer customer in listcustomers)
            //{
            //    Console.WriteLine(customer.ID);
            //}


            #region MyRegion all work able code

            //Console.WriteLine("Before sorting");
            //foreach (Customer c in listcustomers)
            //{
            //    Console.WriteLine(c.Salary);
            //}

            //listcustomers.Sort();

            //Console.WriteLine("After sorting");
            //foreach (Customer c in listcustomers)
            //{
            //    Console.WriteLine(c.Salary);
            //}

            //listcustomers.Reverse();

            //Console.WriteLine("Descending Order");
            //foreach (Customer c in listcustomers)
            //{
            //    Console.WriteLine(c.Salary);
            //}

            //List<int> Numbers = new List<int> { 6, 7, 4, 3, 5,2, 9, 1, 8 };

            //Console.WriteLine("Number before short");
            //foreach (int number in Numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //Numbers.Sort();

            //Console.WriteLine();
            //Console.WriteLine("Number After short");
            //foreach (int number in Numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //Numbers.Reverse();

            //Console.WriteLine();
            //Console.WriteLine("Number in Descending order");
            //foreach (int number in Numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //List<string> Alphabets = new List<string> { "B", "D", "F", "A", "C" };
            //Console.WriteLine();
            //Console.WriteLine("Alphabets Before short");
            //foreach (string Alphabet in Alphabets)
            //{
            //    Console.Write(Alphabet + " ");
            //}

            //Alphabets.Sort();

            //Console.WriteLine();
            //Console.WriteLine("Alphabets After short");
            //foreach (string Alphabet in Alphabets)
            //{
            //    Console.Write(Alphabet + " ");
            //}

            //Alphabets.Reverse();

            //Console.WriteLine();
            //Console.WriteLine("Alphabets in Descending order");
            //foreach (string Alphabet in Alphabets)
            //{
            //    Console.Write(Alphabet + " ");
            //}

            //SortByName sortByName = new SortByName();

            //Console.WriteLine();
            //Console.WriteLine("Sorting By Name");
            //foreach (Customer c in listcustomers)
            //{
            //    Console.Write(c.Name + " ");
            //}

            //listcustomers.Sort(sortByName);

            //Console.WriteLine();
            //Console.WriteLine("Sorting By Name");
            //foreach (Customer c in listcustomers)
            //{
            //    Console.Write(c.Name + " ");
            //}
            #endregion

            Console.ReadKey();
        }

        //private static int compareCustomer(Customer x, Customer y)
        //{
        //    return x.ID.CompareTo(y.ID);
        //}

        public class SortByName : IComparer<Customer>
        {
            public int Compare(Customer x, Customer y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        public class Customer : IComparable<Customer>
        { 
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }

            public int CompareTo(Customer other)
            {
                //if (this.Salary > other.Salary)
                //{
                //    return 1;
                //}
                //else if (this.Salary < other.Salary)
                //{
                //    return -1;
                //}
                //else
                //{
                //    return 0;
                //}

                return this.Salary.CompareTo(other.Salary);
            }
        }


    }
}
