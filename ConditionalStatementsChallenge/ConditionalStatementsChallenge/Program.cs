using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Erik";

            if (name == "Jesse")
            {
                Console.WriteLine("Your name is Jesse");
            }
            else if (name == "Brett")
            {
                Console.WriteLine("Your name is not Jesse");
            }
            else
            {
                Console.WriteLine("Your name is not Jesse or Brett");
            }

            Console.ReadLine();
        }
    }
}
