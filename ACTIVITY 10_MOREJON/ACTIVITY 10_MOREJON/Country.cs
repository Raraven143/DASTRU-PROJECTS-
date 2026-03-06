using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_10_MOREJON
{
    class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }

        public Country(string name, string capital, int population)
        {
            Name = name;
            Capital = capital;
            Population = population;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Country Name: {Name}");
            Console.WriteLine($"Capital: {Capital}");
            Console.WriteLine($"Population: {Population}");
        }

    }

    class Asia : Country
    {
        public string Currency {  get; set; }
        public string Language { get; set; }

        public Asia(string name, string capital, int population, string currency, string language) : base (name, capital, population) 
        {
            Currency = currency;
            Language = language;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Currency: {Currency}");
            Console.WriteLine($"Language: {Language}");
        }
    }
}
