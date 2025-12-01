using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REVIEW1_USING_CONTROL_STRUCTURE_MOREJON
{
    internal class Program
    {
        static void Main(string[] args)
        {
        begin:

            Console.WriteLine("This project will determine what type of number and display its range.");
            Console.WriteLine("");
            Console.Write("Please enter a number: ");
            

            string userInput = Console.ReadLine();

           

            int startNum = number;

            if (startNum % 2 == 0)
            {
                Console.Write($"{startNum} is an EVEN number.\n");
                Console.WriteLine("");
                Console.WriteLine("This is the range of numbers based from the number entered.");

                for (int i = startNum; i >= 2; i -= 2)
                {
                    Console.Write(i + " ");
                }

            }
            else
            {
                Console.WriteLine("This is the range of numbers based from the number you entered.");
            }

            switch (int.TryParse(userInput, out int number))
            {
                case false:
                    Console.WriteLine("Please re-try to enter a numeric value.\n");

                    goto begin;

            }
            int startNum = number;

            Console.WriteLine("\n");
            Console.WriteLine("Do you want to try again (y/n)? ");
            char retry = Convert.ToChar(Console.ReadLine());
            Console.Clear();

            if (retry == 'y')
            {
                goto begin;
            }
            else
            {
                return;
            }           

        }
    }
}
