using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_4_MOREJON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country[,] countries = new Country[2, 3];

            // Asia which represents row 0
            countries[0, 0] = new Asia("Philippines", "Manila", "Philippine Peso (Php)", 112729484, "South East Asia");
            countries[0, 1] = new Asia("Japan", "Tokyo", "Japanese Yen", 124330690, "East Asia");
            countries[0, 2] = new Asia("Saudi Arabia", "Riyadh", "Saudi Riyal", 3466328, "West Asia");

            // Europe represents row 1
            countries[1, 0] = new Europe("Germany", "Berlin", "Euro", 84075075, "German (Deutsch)");
            countries[1, 1] = new Europe("Italy", "Rome", "Euro", 59146260, "Italian");
            countries[1, 2] = new Europe("France", "Paris", "Euro", 66703363, "French");

            // Display all country information using polymorphism
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
