using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_6_MOREJON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MOREJON, RAVEN T. | IT401A | ACTIVITY 6: Inserting Nodes to the Linked List
            LinkedList<string> myFriends = new LinkedList<string>(); //DECLARING THE LINKED LIST

        inputValue:
            Console.Clear();

            //Enter the number of nodes
            Console.Write("Give me the number of your favorite friends you have in your whole life: ");
            int numOfFriends = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //make the length of the nodes between 5 - 10
            if (numOfFriends < 5 || numOfFriends > 10) 
            {
                Console.WriteLine("Please enter a number between 5 and 10.");
                goto inputValue;
            }
            //Input the favourite friend's name
            Console.WriteLine("---Enter the name of the favourite friends you have in your entire life---");
            for (int i = 0; i < numOfFriends; i++) 
            
            {
                Console.Write("Favourite friend #{0}: ", i + 1);
                string friendName = Console.ReadLine();
                myFriends.AddLast(friendName);
            }
            //Sort the linked list
            var sortedFriends = myFriends.OrderBy(name => name).ToList();

            //Displaying the linked list for the favourite friends in users entire life
            Console.Clear();
            Console.WriteLine("\n This is your Favourite Friends in your entire life: ");
            foreach (string friend in myFriends)            
            {
                Console.Write(friend + " --> ");
            }

            Console.WriteLine("NULL"); 
            
            Console.ReadKey();
        }
       
    }
}
