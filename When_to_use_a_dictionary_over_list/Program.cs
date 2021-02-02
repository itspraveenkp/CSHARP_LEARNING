using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace When_to_use_a_dictionary_over_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country1 = new Country() { Code = "AUS", Name = "Australia", Capital = "Canberra" };
            Country country2 = new Country() { Code = "IND", Name = "India", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "United States", Capital = "Washington" };
            Country country4 = new Country() { Code = "GBR", Name = "United Kingdom", Capital = "London" };
            Country country5 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };

            //List<Country> listcountries = new List<Country>();
            //listcountries.Add(country1);
            //listcountries.Add(country2);
            //listcountries.Add(country3);
            //listcountries.Add(country4);
            //listcountries.Add(country5);

            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
            dictionaryCountries.Add(country1.Code, country1);
            dictionaryCountries.Add(country2.Code, country2);
            dictionaryCountries.Add(country3.Code, country3);
            dictionaryCountries.Add(country4.Code, country4);
            dictionaryCountries.Add(country5.Code, country5);


            string strUserChoice = string.Empty;
            do
            {
                Console.Write("Please Enter Country Code ");
                string strCountryCode = Console.ReadLine().ToUpper();

                //Country resultCountry = listcountries.Find(country => country.Code == strCountryCode);

                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] : null;

                if (resultCountry == null)
                {
                    Console.WriteLine("Country Code not valid");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue - YES or NO?");
                    strUserChoice = Console.ReadLine().ToUpper();
                } while (strUserChoice != "NO" && strUserChoice != "YES" );
            }
            while (strUserChoice == "YES");


            Console.WriteLine("Press Any Key to Continue....");
            Console.ReadKey();

        }
    }

    public class Country
    { 
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
}
