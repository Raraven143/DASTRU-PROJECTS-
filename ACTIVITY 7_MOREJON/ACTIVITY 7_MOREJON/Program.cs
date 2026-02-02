using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_7_MOREJON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MOREJON, RAVEN T. | IT401A | ACTIVITY 7:  Inserting Nodes with Exception Handling

            LinkedList<string> myFriends = new LinkedList<string>(); // DECLARING THE LINKED LIST

        inputValue:


            int numOfFriends = 0;
            Console.Clear();

            // Ask the user for the number of friends with error handling
            Console.Write("Give me the number of your favorite friends you have in your whole life (Within 5 - 10): ");
            

            try
            {
                numOfFriends = int.Parse(Console.ReadLine()); // Trying to parse the user input as an integer
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input! Please enter a valid number (Press enter to retry): " + ex.Message);
                Console.ReadKey();
                goto inputValue; // Go back to asking the user for the number of friends
            }

            Console.WriteLine();
            //make the length of the nodes between 5 - 10
            if (numOfFriends < 5 || numOfFriends > 10)
            {
                Console.WriteLine("Please enter a number between 5 and 10 (Press enter to retry).");
                Console.ReadKey();
                goto inputValue;
            }

            // Input the favourite friend's name
            Console.WriteLine("---Enter the name of the favourite friends you have in your entire life---");
            for (int i = 0; i < numOfFriends; i++)
            {
                Console.Write("Favourite friend #{0}: ", i + 1);
                string friendName = Console.ReadLine();
                myFriends.AddLast(friendName);
            }



            // Sort the linked list
            string[] friendArray = myFriends.ToArray();
            Array.Sort(friendArray);
            myFriends = new LinkedList<string>(friendArray);

            // Displaying the linked list for the favourite friends in user's entire life
            Console.Clear();
            Console.WriteLine("\nThis is your Favourite Friends in your entire life: ");
            foreach (string friend in myFriends)
            {
                Console.WriteLine(friend);
            }

            Console.ReadKey();
        }
    }
}
