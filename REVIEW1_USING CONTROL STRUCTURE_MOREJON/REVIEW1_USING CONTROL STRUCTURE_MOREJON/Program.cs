using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REVIEW1_USING_CONTROL_STRUCTURE_MOREJON
{
    //MOREJON, RAVEN T. | REVIEW1: USING CONTROL STRUCTURE | IT401A
    internal class Program
    {
        static void Main(string[] args)
        {

        begin: //For the user to retry again
            Console.WriteLine("This project will determine what type of number and display its range.");
            Console.WriteLine("");
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            Console.WriteLine();

            int number;

            // We use int.TryParse to safely check if the input is a valid number without causing an error.
            bool isNumeric = int.TryParse(userInput, out number); 

            if (!isNumeric)
            {
                // This will only show these two messages for non-numeric input
                Console.WriteLine("Please re-try to enter a numeric value.\n");
                Console.WriteLine("Do you want to try again (y/n)? ");
                char retryInvalid = Convert.ToChar(Console.ReadLine());
                Console.Clear();

                if (retryInvalid == 'y')
                {
                    goto begin;
                }
                else
                {
                    return;
                }
            }
            else // This block only runs if a valid number was entered
            {
                if (number % 2 == 0)
                {
                    // Use the 'number' variable for the message
                    Console.Write($"{number} is an EVEN number.\n");
                    Console.WriteLine("");
                    Console.WriteLine("This is the range of numbers based from the number entered.");

                    for (int i = number; i >= 2; i -= 2)
                    {
                        Console.Write(i + " ");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, cannot provide the range of numbers based from the number you entered.\n");
                }

                Console.WriteLine("\n");
                Console.WriteLine("Do you want to try again (y/n)? ");
                char retryValid = Convert.ToChar(Console.ReadLine());
                Console.Clear();

                if (retryValid == 'y')
                {
                    goto begin;
                }
                else 
                {
                    Console.WriteLine("Thank you for using the Program.");
                }

                // implicit else returns
            }
        }
    }
}
