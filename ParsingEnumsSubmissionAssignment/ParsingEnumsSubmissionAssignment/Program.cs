using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the current day of the week?"); //This asks the user for the day of the week.
            string day = Console.ReadLine(); //This saves the user's input as the string day.
            try //This opens the try block.
            {
                var day1 = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day); //This parses the day string with the Days Of the Week enum to create the day1 variable.
                Console.WriteLine("Today is: " + day1); //This prints the day of the week.
            }
            catch //This opens the catch statement.
            {
                Console.WriteLine("Please enter an actual day of the week."); //This tells the user to enter an actual day of the week.
            }

            Console.ReadLine(); //This ensures the console stays open.
        }
        public enum DaysOfTheWeek //This establishes the DaysOfTheWeek Enum, and its values.
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
