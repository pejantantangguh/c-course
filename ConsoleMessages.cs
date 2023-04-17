using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class ConsoleMessages
    {
        public static void SayHi(string firstName) { 
            Console.WriteLine($"Hello {firstName}");
            Console.WriteLine("Hope you had a good day!");
        }
        public static string GetUserName()
        {
            Console.WriteLine("Please enter your User Name?");
            string UserName = Console.ReadLine();
            return UserName;
        }

    }

}