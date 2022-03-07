using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOutputChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;

            if (age > 20)
            {
                Console.WriteLine("You may purchase alcohol.");
            }

            else if (age <= 20)
            {
                Console.WriteLine("You may not purchase alcohol.");
            }
            Console.ReadLine();
        }
    }
}
