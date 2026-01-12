using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_3_MOREJON
{
    internal class Program
    //MOREJON, RAVEN T. | IT401A | ACTIVITY 3: Two-Dimensional Array

    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Here are the student of class Harmony's favorite country to visit ------");
            Console.WriteLine();

            //Array declaration 
            string[,] countries = new string[4, 3]
            {
                {"Philippines", "Japan", "China" },
                {"Netherlands", "Greenlands", "Iceland" },
                {"Denmark", "France", "South Korea" },
                {"Switzerland", "Netherlands", "Germany" }
            };

            //Display Array  elements
            Console.Write("{0,-15}{1,-15}{2,-15}\n", "Student 1", "Student 2", "Student 3");

            // Print separator
            Console.WriteLine(new string('-', 45));

            // Print table rows
            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("{0,-15}", countries[r, c]);
                }
                Console.WriteLine();
            }
                Console.ReadKey();

        
        }
    }
}
