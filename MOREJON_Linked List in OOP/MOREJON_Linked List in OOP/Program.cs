using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOREJON_Linked_List_in_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountryManager manager = new CountryManager();
            bool running = true;

            Console.WriteLine("=== COUNTRY MANAGEMENT SYSTEM ===");


            while (running)
            {
                Console.Clear();
                Console.WriteLine("\nCHOOSE WHAT TO DO!");
                Console.WriteLine("\n1. Add Asia\n2. Add Europe\n3. Remove Currency\n4. Display All\n5. Exit");

                // Re-using the try-catch style for the menu
                int choice = UserInput.GetInt("Select Option: ");

                Console.Clear();
                switch (choice)
                {
                    case 1:
                        // Calls the method that asks for Name, Pop, etc.
                        manager.AddCountry(UserInput.GetAsiaInput());
                        break;
                        

                    case 2:
                        // Calls the method that asks for Name, Pop, etc.
                        manager.AddCountry(UserInput.GetEuropeInput());
                        break;

                    case 3:
                        string target = UserInput.GetString("Enter currency to remove: ");
                        manager.RemoveCountry(target);
                        break;

                    case 4:
                        manager.DisplayAll();
                        break;

                    case 5:
                        running = false;
                        Console.WriteLine("Closing...");
                        break;

                    default:
                        Console.WriteLine("Please choose 1-5.");
                        break;
                }
                if (running)
                {
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                }
            }
        }
    }
}