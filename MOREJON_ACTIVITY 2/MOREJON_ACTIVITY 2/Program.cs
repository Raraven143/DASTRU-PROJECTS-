using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOREJON_ACTIVITY_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating Array Object
            Country[] countries = new Country[6];

            //Assigning values to objects
          
            countries[0] = new Asia("Philippines", "Manila", "Philippine Peso (Php)", 112729484, "South East Asia");
            countries[1] = new Asia("Japan", "Tokyo", "Japanese Yen", 124330690, "East Asia");
            countries[2] = new Asia("Saudi Arabia", "Riyadh", "Saudi Riyal", 3466328, "West Asia");
            countries[3] = new Europe("Germany", "Berlin", "Euro", 84075075, "German (Deutsch)");
            countries[4] = new Europe("Italy", "Rome", "Euro", 59146260, "Italian");
            countries[5] = new Europe("France", "Paris", "Euro", 66703363, "French");

            //Displaying info each bags
            foreach (Country country in countries) 
            {
                
                country.DisplayInfo();
            }

            Console.ReadKey();
        }
    }
}
