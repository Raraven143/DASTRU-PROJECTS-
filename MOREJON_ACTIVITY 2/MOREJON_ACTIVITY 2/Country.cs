using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOREJON_ACTIVITY_2

//MOREJON, RAVEN T | ACTIVITY 2: Single Dimensional Array of Objects in OOP | IT401A
{
    internal class Country //Base class
    {
        //Properties of a parent class
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public int Population { get; set; }

        public Country(string name, string capital, string currency, int population) //Parameterized constructor for Base class
        {
            Name = name;
            Capital = capital;
            Currency = currency;
            Population = population;
        }
        
        public virtual void DisplayInfo() //Method of Base class
        {

        }
        
    }   

    class Asia : Country //The child class Asia
    {
        public string Region { get; set; } //property of a child class Asia
        
        //Parameterized Constructor of the child class Asia
        public Asia(string name, string capital, string currency, int population, string region) 
        : base(name, capital, currency, population)
        {
            Region = region;
        }

        public override void DisplayInfo() //Overriden method for child class Asia
        {
            Console.WriteLine("_____Details of an Asian Countries_____");
            Console.WriteLine($"Region of the Country: {Region}");
            base.DisplayInfo();
        }

    }
    class Europe : Country //The child class Africa
    {
        public string Language { get; set; } //property of a child class Europe

        //Parameterized Constructor of the child class Europe
        public Europe(string name, string capital, string currency, int population, string language) 
        : base(name, capital, currency, population)
        {
            Language = language;
        }

        public override void DisplayInfo() //Overriden method for child class Europe
        {
            Console.WriteLine("_____Details of an Europian Countries_____");
            Console.WriteLine($"Main Language of the Country: {Language}");
            base.DisplayInfo();
        }
    }

}
