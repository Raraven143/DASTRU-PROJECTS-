using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_5_MOREJON
{
    internal class UserInput
    {
        //Method for string input
        public static string GetString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        //Method for int input
        public static int GetInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
