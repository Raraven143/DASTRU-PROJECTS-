using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOREJON_Linked_List_in_OOP
{
    public abstract class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public int Population { get; set; }

        public Country(string name, string capital, string currency, int population)
        {
            Name = name; Capital = capital; Currency = currency; Population = population;
        }

        public abstract void DisplayInfo();
    }

    public class Asia : Country
    {
        public string Region { get; set; }
        public Asia(string n, string c, string cur, int p, string r) : base(n, c, cur, p) => Region = r;

        public override void DisplayInfo() =>
            Console.WriteLine($"[ASIA] {Name} | Capital: {Capital} | Currency: {Currency} | Pop: {Population:N0} | Region: {Region}");
    }

    public class Europe : Country
    {
        public string Language { get; set; }
        public Europe(string n, string c, string cur, int p, string l) : base(n, c, cur, p) => Language = l;

        public override void DisplayInfo() =>
            Console.WriteLine($"[EUROPE] {Name} | Capital: {Capital} | Currency: {Currency} | Pop: {Population:N0} | Lang: {Language}");
    }
}
