using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MOREJON_ACTIVITY_9
{
    //MOREJON, RAVEN T. || IT401A || ACTIVITY 9: Stack in Procedural Approach
    namespace StackActivity
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // The stack in Data Structure
                Stack<string> Country = new Stack<string>();
                bool running = true;

                Console.Clear();
                Console.WriteLine("=== FAVORITE COUNTRY TRACKER ===");

                while (running)
                {
                    try
                    {
                        // Let user choose what to do
                        Console.WriteLine("\n--- HERE'S WHAT TO DO ON YOUR COUNTRY TO VISIT LISTS! ---");
                        Console.WriteLine("1. Add your favourite Country to Visit.");
                        Console.WriteLine("2. Remove the latest country.");
                        Console.WriteLine("3. View the final Countries you input in your stack.");

                        Console.Write("\nEnter your choice: ");
                        string choice = Console.ReadLine();
                        Console.Clear();

                        switch (choice)
                        {
                            case "1":
                                Console.Write("What is the name of your favorite country? ");
                                string countryInput = Console.ReadLine();

                                if (string.IsNullOrWhiteSpace(countryInput))
                                    throw new Exception("Country name cannot be empty.");

                                Country.Push(countryInput);
                                Console.Clear();
                                Console.WriteLine($"Output: '{countryInput}' added successfully.");
                                break;

                            case "2":
                                if (Country.Count == 0)
                                {
                                    Console.WriteLine("Output: Error! The stack is empty. Nothing to pop.");
                                }
                                else
                                {
                                    string removed = Country.Pop();
                                    Console.Clear();
                                    Console.WriteLine($"Output: Removed '{removed}' from your favorites.");
                                }
                                break;

                            case "3":
                                Console.Clear();
                                Console.WriteLine("=== FINAL FAVORITE COUNTRY LIST ===");

                                if (Country.Count == 0)
                                {
                                    Console.WriteLine("Your list is empty.");
                                }
                                else
                                {
                                    Console.WriteLine("Final List (Latest to Oldest):");
                                    int count = 0;
                                    foreach (var item in Country)
                                    {
                                        // Use Write instead of WriteLine to keep them together
                                        Console.Write("- " + item);
                                        count++;
                                        Console.WriteLine(); // New line for each country
                                    }
                                }
                                running = false; // Ends the loop
                                Console.WriteLine("\nPress any key to exit...");
                                Console.ReadKey();
                                break;

                            default:
                                Console.WriteLine("Output: Invalid input. Please enter a number (1, 2, or 3) to continue.");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Output Error: {ex.Message}");
                    }
                } // End of While
            } // End of Main
        }
    }
}
        