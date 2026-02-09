using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOREJON_Linked_List_in_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Country> countryList = new LinkedList<Country>();

            Console.WriteLine("=== COUNTRY LINKED LIST PROGRAM ===\n");

            // Add first country (Asia)
            Console.WriteLine("Enter details for the first country (Asian Country):");
            countryList.AddFirst(CreateAsia());
            Console.WriteLine("Country added successfully!\n");

            // Add second country (Europe)
            Console.WriteLine("Enter details for the second country (European Country):");
            countryList.AddFirst(CreateEurope());
            Console.WriteLine("Country added successfully!\n");

            // Add country at the beginning
            Console.WriteLine("Enter details for another asian country:");
            countryList.AddLast(CreateAsia());
            Console.WriteLine("Country added successfully!\n");

            // Add country at the last
            Console.WriteLine("Enter details for another European country:");
            countryList.AddLast(CreateEurope());
            Console.WriteLine("Country added successfully!\n");

            // Display all countries
            Console.WriteLine("Displaying all countries in the linked list:\n");
            DisplayCountries(countryList);

            
        }

        static Asia CreateAsia()
        {
            string name = UserInput.GetString("Country Name: ");
            string capital = UserInput.GetString("Capital: ");
            string currency = UserInput.GetString("Currency: ");
            int population = UserInput.GetInt("Population: ");
            string region = UserInput.GetString("Region: ");

            return new Asia(name, capital, currency, population, region);
        }

        static Europe CreateEurope()
        {
            string name = UserInput.GetString("Country Name: ");
            string capital = UserInput.GetString("Capital: ");
            string currency = UserInput.GetString("Currency: ");
            int population = UserInput.GetInt("Population: ");
            string language = UserInput.GetString("Main Language: ");

            return new Europe(name, capital, currency, population, language);
        }

        static void DisplayCountries(LinkedList<Country> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("No countries in the list.");
                return;
            }

            foreach (Country c in list)
            {
                c.DisplayInfo();
            }
        }
    }
    
}
