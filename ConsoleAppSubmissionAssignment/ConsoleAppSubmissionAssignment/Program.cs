using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number other than 100 for the while loop: "); //This asks the user to create a number for use with the while loop.
            double number = Convert.ToDouble(Console.ReadLine()); //This converts their number to a double
            bool boolean = number == 100; //This defines the boolean for the while loop
            Console.WriteLine("Guess any number for the do while loop: "); //This asks the user to provide a number for the do while loop.
            double newnumber = Convert.ToDouble(Console.ReadLine()); //This converts their number to a double
            bool newboolean = newnumber == 100; //This defines the boolean for the do while loop

            while (!boolean) //This applies the boolean to the while loop
            {
                switch(number) //This applies the number double to the switch statement
                {
                    case 100: //This tells the switch statement what to display for the correct answer
                        Console.WriteLine("You guessed correctly for the while loop!"); //This tells the user they guessed correctly for the while loop
                        Console.ReadLine();//This ensures the message displays
                        boolean = true; //This changes the boolean to true
                        break; //This applies a break to the loop
                    default: //This tells the switch statement what to display for an incorrect answer
                        Console.WriteLine("You guessed incorrectly for the while loop!"); //This tells the user they guessed incorrectly
                        Console.WriteLine("Guess a number for the while loop? "); //This instructs the user to guess another number.
                        number = Convert.ToInt32(Console.ReadLine()); //This converts their new number to the number double
                        break; //This applies a break to the loop
                }

                do //This establishes the do statement
                {
                    switch (newnumber) //This applies the newnumber double to the switch statement
                    {
                        case 100: //This tells the switch statement what to display ofr the correct answer
                            Console.WriteLine("You guessed correctly for the do while loop!"); //This tells the user they guessed correctly for the do while loop
                            Console.ReadLine(); //This ensures the message displays
                            newboolean = true; //This changes the boolean to true
                            break; //This applies a break to the loop
                        default: //This tells the switch statement what to display for an incorrect answer
                            Console.WriteLine("You guessed incorrectly for the do while loop!"); //This tells the user they guessed incorrectly
                            Console.WriteLine("Guess a number for the do while loop? "); //This instructs the user to guess another number.
                            newnumber = Convert.ToDouble(Console.ReadLine()); //This converts their new number to the newnumber double
                            break; //This applies a break to the loop
                    }
                } while (!newboolean); //This tells the loop to continue as long as newboolean is not true

                Console.Read(); //This ensures the console stays open
            }
        } 
    }
}
