using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_5_MOREJON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country[,] countries = new Country[2, 3];

            //ASIAN Countries as Row 0
            Console.WriteLine("ENTER DETAILS FOR ASIAN COUNTRIES\n");

            for (int c = 0; c < 3; c++)
            {
                Console.WriteLine($"Asian Country #{c + 1}");

                string name = UserInput.GetString("Country Name: ");
                string capital = UserInput.GetString("Capital: ");
                string currency = UserInput.GetString("Currency: ");
                int population = UserInput.GetInt("Population: ");
                string region = UserInput.GetString("Region: ");

                countries[0, c] = new Asia(name, capital, currency, population, region);
                Console.WriteLine();
            }

            //Europian Country as Row 1
            Console.WriteLine("ENTER DETAILS FOR EUROPEAN COUNTRIES\n");

            for (int c = 0; c < 3; c++)
            {
                Console.WriteLine($"European Country #{c + 1}");

                string name = UserInput.GetString("Country Name: ");
                string capital = UserInput.GetString("Capital: ");
                string currency = UserInput.GetString("Currency: ");
                int population = UserInput.GetInt("Population: ");
                string language = UserInput.GetString("Main Language: ");

                countries[1, c] = new Europe(name, capital, currency, population, language);
                Console.WriteLine();
            }

            
            Console.WriteLine("\n ---DISPLAYING ALL COUNTRY INFORMATION--- \n");

            for (int r = 0; r < countries.GetLength(0); r++)
            {
                for (int c = 0; c < countries.GetLength(1); c++)
                {
                    countries[r, c].DisplayInfo();
                }
            }

            Console.ReadKey();
        }
    }
   
}