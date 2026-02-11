using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOREJON_Linked_List_in_OOP
{
    internal class CountryManager
    {
            private LinkedList<Country> countryList = new LinkedList<Country>();

        public void AddCountry(Country country)
        {
            if (country != null)
            {
                countryList.AddLast(country);
                Console.WriteLine("Country added successfully!");
            }
        }

            public bool RemoveCountry(string currency)
            {
                var node = countryList.First;

                while (node != null)
                {
                    LinkedListNode<Country> next = node.Next; // Track next before potentially removing

                    if (node.Value.Currency.Equals(currency, StringComparison.OrdinalIgnoreCase))
                    {
                        // Logic: Users don't like removing specific currencies (e.g., USD or PHP)
                        // You can customize this list of 'protected' currencies
                      countryList.Remove(node);
                        
                        Console.WriteLine($"Bag removed.");
                    return true;
                        
                    }
                    node = next;
                }

               Console.WriteLine("No country found.");
               return false;
            }

            public void DisplayAll()
            {
                Console.WriteLine("\n--- CURRENT COUNTRY LIST ---");
                if (countryList.Count == 0) Console.WriteLine("The list is empty.");
                foreach (var country in countryList)
                {
                    country.DisplayInfo();
                }
            }
        }

    }

