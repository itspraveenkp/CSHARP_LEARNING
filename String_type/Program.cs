using System;

class Program
{
    static void Main()
    {
        string Name = "Praveen";
        Console.WriteLine("Name :{0}", Name);

        //For Print or Display double quote("\)
        string OtherName = "\"Praveen\"";
        Console.WriteLine(OtherName);

        //For Print or Display in new line (\n) 
        string newline = "one\nTwo\nThree";
        Console.WriteLine(newline);

        //Without Verbatim Literal (Less readability)
        string wrongtypePath = "C:\\Users\\pprajapa\\Downloads\\Garbage\\Learn Document\\Web Development Tutorials";
        Console.WriteLine(wrongtypePath);

        //With Verbatim Literal (better readability)
        string Righttypepath = @"C:\Users\pprajapa\Downloads\Garbage\Learn Document\Web Development Tutorials";
        Console.WriteLine(Righttypepath);



        Console.ReadKey();
    }
}