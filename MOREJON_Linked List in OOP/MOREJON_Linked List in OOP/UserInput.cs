using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOREJON_Linked_List_in_OOP
{
    internal class UserInput
    {
        public static string GetString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int GetChoice()
        {
            try
            {
                Console.Write("\nEnter Choice: ");
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                return -1; // Fallback for the switch case
            }
        }

        // Your requested try-catch style for numbers
        public static int GetInt(string message)
        {
            try
            {
                Console.Write(message);
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid numeric input. Defaulting to 0.");
                return 0;
            }
        }

        // New method to collect all Asian country details at once
        public static Asia GetAsiaInput()
        {
            Console.WriteLine("\n--- Entering Asian Country Details ---");
            string name = GetString("Enter Name: ");
            string cap = GetString("Enter Capital: ");
            string curr = GetString("Enter Currency: ");
            int pop = GetInt("Enter Population: ");
            string reg = GetString("Enter Region: ");
            return new Asia(name, cap, curr, pop, reg);
        }

        // New method to collect all European country details at once
        public static Europe GetEuropeInput()
        {
            Console.WriteLine("\n--- Entering European Country Details ---");
            string name = GetString("Enter Name: ");
            string cap = GetString("Enter Capital: ");
            string curr = GetString("Enter Currency: ");
            int pop = GetInt("Enter Population: ");
            string lang = GetString("Enter Main Language: ");
            return new Europe(name, cap, curr, pop, lang);
        }
    }
}

