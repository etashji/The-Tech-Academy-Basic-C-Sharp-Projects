using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try //This opens the try/catch block.
            {
                Console.WriteLine("How old are you?"); //This asks the user to enter their age.
                int age = Convert.ToInt32(Console.ReadLine()); //This converts their answer into an integer and saves it as the age variable.
                if (age < 1) //This opens the if statement for if the age the user enters is less than 1.
                {
                    throw new ZeroNegativeException(); //This tells the computer to throw the ZeroNegativeException if the age the user entered is less than 1.
                }
                int negativeAge = -age; //This converts the age integer into a negative number for use with the now.AddYears() method.
                Console.WriteLine("Have you had your birthday yet this year?"); //This asks the user if they have had their birthday yet this year.
                string answer = Console.ReadLine(); //This saves their answer as the string answer.
                if (answer != "yes" || answer != "no") //This opens the if statement for if the user's answer does not equal "yes" or "no"
                {
                    throw new Exception(); //This tells the if statement that if it is fulfilled, it throws an exception.
                }

                DateTime now = DateTime.Now; //This instantiates the now DateTime as today's date.

                if (answer == "yes") //This opens the if statement for if the user's answer is yes.
                {
                    DateTime birthyear = now.AddYears(negativeAge); //This calculates the user's birthyear by subtracting the age from the current date.
                    Console.WriteLine("You were born in the year {0}.", birthyear.Year); //This display's the user's birth year in years.
                }

                if (answer == "no") //This opens the if statement if the user's answer is "no."
                {
                    DateTime birthyear = now.AddYears(negativeAge - 1); //This calculates the user's birthyear by subtracting the user's age and an additional year (because they haven't had their birthday yet this year.)                    Console.WriteLine("You were born in the year {0}.", birthyear.Year);
                }
            }
            catch (ZeroNegativeException) //This opens the catch statement for if the answer is zero or negative.
            {
                Console.WriteLine("You must enter a positive nonzero integer."); //This tells the user to put in a number that is not zero and is positive.
                Console.ReadLine(); //This ensures the console stays open so the user can read the above statement.
                return;//This closes the console.
            }
            catch (Exception) //This catches any other exception except if the exception is a zero or negative number.
            {
                Console.WriteLine("Invalid input."); //This tells the user they put in an invalid input.
                Console.ReadLine(); //This ensures the console stays open so the user can read the above statement.
                return; //This closes the console.
            }
            Console.ReadLine(); //This ensures the console stays open.
        }
    }
}
