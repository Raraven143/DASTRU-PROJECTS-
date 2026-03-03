using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MOREJON_ACTIVITY_9
{
    //MOREJON, RAVEN T. || IT401A || ACTIVITY 9:  Stack in Procedural Approach
    internal class Program
    {
        static void Main(string[] args)
        {
            //The stack in Data Structure
            Stack<string> Country = new Stack<string>(5);

            bool running = true;
              
            Console.Clear();
            Console.WriteLine("=== FAVORITE COUNTRY TRACKER ===");

            
            while (running)

            {
                Console.WriteLine("\n--- HERE'S WHAT TO DO ON YOUR COUNTRY TO VISIT LISTS! ---");
                Console.WriteLine("1. Add your favourite Country to Visit (Maximum at 5).");
                Console.WriteLine("2. Remove the latest country.");
                Console.WriteLine("3. Check the total Countries.");
                Console.WriteLine("4. View all the Countries you input.");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                
                try
                {
                   
                    string choice = Console.ReadLine();
                    Console.Clear();
                    switch (choice)
                    {
                        case "1":
                            // Requirement: Data entry via user input
                            Console.Write("What is the name of your favorite country? ");
                            string country = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(country))
                                throw new Exception("Country name cannot be empty.");

                            // Reference: myStack.Push()
                            Country.Push(country);
                            Console.WriteLine($"Output: '{country}' added successfully.");
                            break;

                        case "2":
                            // Logic-based Exception Handling for Stack Underflow
                            if (Country.Count == 0)
                            {
                                Console.WriteLine("Output: Error! The stack is empty. Nothing to pop.");
                            }
                            else
                            {
                                // Reference: myStack.Pop()
                                string removed = Country.Pop();
                                Console.WriteLine($"Output: Removed '{removed}' from your favorites.");
                            }
                            break;

                        case "3":
                            // NEW OPERATION: Using .Count property
                            int total = Country.Count;
                            Console.WriteLine($"Output: There are currently {total} favorite country(ies) in your stack.");
                            break ;

                        case "4":
                            Country.Peek();
                            if (Country.Count == 0)
                            {
                                Console.WriteLine("Output: The stack is empty.");
                                return;
                            }

                            Console.Write("Output (Latest to Oldest): ");

                            // Reference: foreach (var item in myStack) Console.Write(item + ",");
                            foreach (var item in Country)
                            {
                                Console.Write(item + ", ");
                            }
                            Console.WriteLine();
                            break;

                        case "5":
                            running = false;
                            Console.WriteLine("Exiting program. Goodbye!");
                            break;

                        default:
                            Console.WriteLine("Output: Invalid selection. Choose 1-5.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Output Error: {ex.Message}");
                }
            }
        }

        
    }
}

