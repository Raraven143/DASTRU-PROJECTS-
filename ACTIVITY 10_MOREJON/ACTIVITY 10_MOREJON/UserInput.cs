using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_10_MOREJON
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
            try
            {
                Console.Write(message);
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please input a valid numeric value. Default into O");
                return 0;
            }
        }

    }
}
