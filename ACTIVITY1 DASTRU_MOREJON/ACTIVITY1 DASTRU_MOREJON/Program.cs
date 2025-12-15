using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY1_DASTRU_MOREJON
{
    internal class Program
    {
        //MOREJON, RAVEN T. || IT401A || ACTIVITY 1: Single Dimensional Array in Procedural Programming
        static void Main(string[] args)
        {
            int size = 0;

            // Ask for array size with validation
            while (true)
            {
                Console.Write("Enter number of countries (5 - 10): ");
                if (int.TryParse(Console.ReadLine(), out size))
                {
                    if (size >= 5 && size <= 10)
                        break;
                    else
                        Console.WriteLine("Please enter a number between 5 and 10.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            string[] countries = new string[size];

            // Input country names
            for (int country = 0; country < size; country++)
            {
                while (true)
                {
                    Console.Write($"Enter country #{country + 1}: ");
                    string input = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        countries[country] = input.Trim();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Country name cannot be empty.");
                    }
                }
            }

            // Ask for sorting order
            char choice;
            while (true)
            {
                Console.Write("Sort order (A for Ascending, D for Descending): ");
                if (char.TryParse(Console.ReadLine().ToUpper(), out choice))
                {
                    if (choice == 'A' || choice == 'D')
                        break;
                    else
                        Console.WriteLine("❌ Please enter A or D only.");
                }
                else
                {
                    Console.WriteLine("❌ Invalid input.");
                }
            }

            // Sort array
            Array.Sort(countries);
            if (choice == 'D')
                Array.Reverse(countries);

            // Display result
            Console.WriteLine("\nSorted List of Countries:");
            for (int i = 0; i < countries.Length; i++)
            {
                Console.WriteLine($"- {countries[i]}");
            }

            Console.WriteLine("\nProgram finished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
