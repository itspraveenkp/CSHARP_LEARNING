using System;

class Program
{
    static void Main()
    {
        //reference can have null values
        string Name = null;

        //integer is not nullable value type so it can not store a null value
        //int i = null;

        //if i want to store null value into integer so how do i do that
        int? j = null; //this is null able value

        
        bool? Areyoumajor = null;

        #region Nullable type
        if (Areyoumajor == true)
        {
            Console.WriteLine("User is major");
        }

        else if (Areyoumajor == false)
        {
            Console.WriteLine("User is not major");
        }
        //also we can write false statement like this
        //else if (!Areyoumajor.Value)
        //{
        //    Console.WriteLine("User is not major");
        //}

        else
        {
            Console.WriteLine("User is did not answer the question..!");
        }
        #endregion

        //int? TicketsOnSale = null;
        int? TicketsOnSale = 100;
        int AvailableTickets;

        //if (TicketsOnSale == null)
        //{
        //    AvailableTickets = 0;
        //}
        //else
        //{
        //    //getting error on TicketsOnSale for remove error add(value) like TicketsOnSale.value
        //    AvailableTickets = TicketsOnSale.Value;

        //    //another option is use cast operator like (int)
        //    AvailableTickets = (int)TicketsOnSale;
        //}

        //we can write these into single line
        //like
        AvailableTickets = TicketsOnSale ?? 0;  

        Console.WriteLine("Available Tickets = {0}", AvailableTickets);



        Console.ReadKey();
    }
}

