using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now; //This creates the now DateTime out of the current DateTime.
            Console.WriteLine("The current time is " + now + "."); //This prints the current time using the now DateTime.
            Console.WriteLine("How many hours would you like to add to the current time?"); //This asks the user to put in a number of hours to add to the DateTime.
            int X = Convert.ToInt32(Console.ReadLine()); //This converts the user's input to an integer.
            Console.WriteLine("It will be " + now.AddHours(X) + " in " + X + " hours."); //This prints what time it will be after the number of hours the user entered.
            Console.ReadLine(); //This ensures the console stays open.
        }
    }
}
