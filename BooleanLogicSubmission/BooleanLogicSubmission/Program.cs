using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");//This asks the user their age
            int age = Convert.ToInt32(Console.ReadLine());//This converts the user's response to an integer

            Console.WriteLine("Have you ever had a DUI?");//This asks the user if they've had any DUIs.
            bool DUI = Convert.ToBoolean(Console.ReadLine());//This converts the user's response to a boolean

            Console.WriteLine("How many speeding tickets do you have?");//This asks the user how many speeding tickets they have
            int tickets = Convert.ToInt32(Console.ReadLine()); //This converts the user response to an integer

            bool ageBool = age > 15; //This creates a boolean for if the age integer is greater than 15.
            bool DUIBool = !DUI; //This create a boolean that is the opposite of the DUI boolean, ensuring that they wil not qualify if they have a DUI.
            bool ticketBool = tickets <= 3; //This creates a boolean for if the tickets are less than or equal to 3.

            Console.WriteLine("Qualified?"); //This asks whether or not the user is qualified.
            Console.WriteLine(ageBool && DUIBool && ticketBool); //This creates a boolean of whether or not all three of ageBool, DUIBool, and ticketBool are true.
            Console.ReadLine();//This ensures the console stays open.

        }
    }
}
