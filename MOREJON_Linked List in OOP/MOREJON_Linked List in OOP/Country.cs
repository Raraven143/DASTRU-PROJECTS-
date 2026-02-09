using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOREJON_Linked_List_in_OOP
{
    internal class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public int Population { get; set; }

        public Country(string name, string capital, string currency, int population)
        {
            Name = name;
            Capital = capital;
            Currency = currency;
            Population = population;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Country Name : {Name}");
            Console.WriteLine($"Capital      : {Capital}");
            Console.WriteLine($"Currency     : {Currency}");
            Console.WriteLine($"Population   : {Population:N0}");
        }
    }

    class Asia : Country
    {
        public string Region { get; set; }

        public Asia(string name, string capital, string currency, int population, string region)
            : base(name, capital, currency, population)
        {
            Region = region;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("=== Asian Country ===");
            base.DisplayInfo();
            Console.WriteLine($"Region       : {Region}");
            Console.WriteLine();
        }
    }

    class Europe : Country
    {
        public string Language { get; set; }

        public Europe(string name, string capital, string currency, int population, string language)
            : base(name, capital, currency, population)
        {
            Language = language;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("=== European Country ===");
            base.DisplayInfo();
            Console.WriteLine($"Language     : {Language}");
            Console.WriteLine();
        }
    }
}