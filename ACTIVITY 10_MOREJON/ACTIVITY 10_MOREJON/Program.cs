using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACTIVITY_10_MOREJON
{
    internal class Program
    {
        static void Main()

        {
            Queue<Country> countries = new Queue<Country>();

            Console.WriteLine("--- Add an Asian Country ---");
            string name = UserInput.GetString("Name: ");
            string capital = UserInput.GetString("Capital: ");
            int population = UserInput.GetInt("Population: ");
            string currency = UserInput.GetString("Currency: ");
            string language = UserInput.GetString("Language: ");

            countries.Enqueue(new Asia(name, capital, population, currency, language));

            // 3. Adding a standard 'Country' object to the same queue
            Console.WriteLine("\nAdding a General Country:");
            countries.Enqueue(new Country("France", "Paris", 67000000));

            // 4. Processing the Queue (OOP Style)
            Console.WriteLine("\n--- Displaying All Countries in Queue ---");

            while (countries.Count > 0)
            {
                // Dequeue returns the base type 'Country'
                Country current = countries.Dequeue();

                // This calls the 'override' version if it's Asia, 
                // or the 'virtual' version if it's Country
                current.DisplayInfo();
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("Queue is now empty. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
