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

        public static int GetInt(string message)
        {
            while (true)
            {
                try
                {
                    Console.Write(message);
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }
    }
}
