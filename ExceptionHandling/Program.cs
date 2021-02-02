using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        
        try
        {
            //StreamReader streamReader = new StreamReader(@"D:\Learn Document\Bootstrap\Learn_Note.txt");
            //StreamReader streamReader = new StreamReader(@"D:\Learn Document\Bootstrap\LearnNote.txt");
            StreamReader streamReader = new StreamReader(@"D:\Learn Document\Bootstrap1\LearnNote.txt");
            Console.WriteLine(streamReader.ReadToEnd());

        }
        
        catch (FileNotFoundException ex)
        {
            //Console.WriteLine(ex.Message);
            //Console.WriteLine(ex.StackTrace);

            //Log the details to DB
            Console.WriteLine("Please Check file if the file {0} exists", ex.FileName);
        }
        catch (DirectoryNotFoundException DNFE)
        {
            Console.WriteLine(DNFE.Message);
            //Console.WriteLine("Directory not found");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        //finally
        //{
        //    //streamReader.Close();
        //    Console.WriteLine("Finally BLock");
        //}
        Console.ReadKey();
        // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
    }
}

