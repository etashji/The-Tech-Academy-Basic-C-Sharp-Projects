using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArraySubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Books = new string[5]; //This defines the Books array
            Books[0] = "King James Bible"; //This defines the element of the Books array at position 0.
            Books[1] = "Heart of Darkness"; //This defines the element of the Books array at position 1.
            Books[2] = "The Adventures of Huckleberry Finn"; //This defines the element of the Books array at position 2.
            Books[3] = "A Brave New World"; //This defines the element of the Books array at position 3.
            Books[4] = "1984"; //This defines the element of the Books array at position 4.

            Console.WriteLine("Which Book do you choose? Please choose 0, 1, 2, 3, or 4: "); //This asks the user to choose a book.
            int BookChoice = Convert.ToInt32(Console.ReadLine()); //This converts the user's input to an integer
            bool ValidBook = BookChoice < 5; //This establishes the ValidBook boolean for use with the do while loop for the message to display when a user puts in invalid input.

            do //This is the do while loop for when a user puts in invalid input.
            {
                switch (BookChoice) //This establishes the switch statement with the BookChoice Integer
                {
                    case 0: //This tells the console what to display if the user puts in a 0.
                        Console.WriteLine("You have chosen: " + Books[BookChoice]); //This tells the user which book they chose.
                        ValidBook = true; //This sets the ValidBook boolean to true.
                        break; //This creates a break for the switch statement.
                    case 1: //This tells the console what to display if the user puts in a 1. 
                        Console.WriteLine("You have chosen: " + Books[BookChoice]); //This tells the user which book they chose.
                        ValidBook = true; //This sets the ValidBook boolean to true.
                        break; //This creates a break for the switch statement.
                    case 2: //This tells the console what to display if the user puts in a 2.
                        Console.WriteLine("You have chosen: " + Books[BookChoice]); //This tells the user which book they chose.
                        ValidBook = true; //This sets the ValidBook boolean to true.
                        break; //This creates a break for the switch statement.
                    case 3: //This tells the console what to display if the user puts in a 3.
                        Console.WriteLine("You have chosen: " + Books[BookChoice]); //This tells the user which book they chose.
                        ValidBook = true; //This sets the ValidBook boolean to true.
                        break; //This creates a break for the switch statement.
                    case 4: //This tells the console what to display if the user puts in a 4.
                        Console.WriteLine("You have chosen: " + Books[BookChoice]); //This tells the user which book they chose.
                        ValidBook = true; //This sets the ValidBook boolean to true.
                        break; //This creates a break for the switch statement.
                    default: //This tells the console what to display if the user puts in invalid input.
                        Console.WriteLine("That is not a valid choice."); //This tells the user they did not make a valid choice.
                        Console.WriteLine("Which Book do you choose? Please choose 0, 1, 2, 3, or 4: "); //This asks the user to choose a book.
                        BookChoice = Convert.ToInt32(Console.ReadLine()); //This changes the BookChoice integer to the user's new choice.
                        break; //This creates a break for the switch statement.
                }
            } while (!ValidBook); //This tells the console to repeat the loop as long as ValidBook is not true.

            int[] Integers = new int[5]; //This defines the Integers array
            Integers[0] = 0; //This defines the element of the Integers array at position 0.
            Integers[1] = 1; //This defines the element of the Integers array at position 1.
            Integers[2] = 2; //This defines the element of the Integers array at position 2.
            Integers[3] = 3; //This defines the element of the Integers array at position 3.
            Integers[4] = 4; //This defines the element of the Integers array at position 4.

            Console.WriteLine("Which of the following numbers is your favorite? Please choose 0, 1, 2, 3, or 4: "); //This asks the user to choose a number.
            int FavNum = Convert.ToInt32(Console.ReadLine()); //This converts the user's input to an integer
            bool ValidNum = FavNum < 5; //This establishes the ValidNum boolean for use with the do while loop for the message to display when a user puts in invalid input.

            do //This is the do while loop for when a user puts in invalid input.
            {
                switch (FavNum) //This establishes the switch statement with the FavNum Integer
                {
                    case 0: //This tells the console what to display if the user puts in a 0.
                        Console.WriteLine("You have chosen: " + Integers[FavNum]); //This tells the user which number they chose.
                        ValidNum = true; //This sets the ValidNum boolean to true.
                        break; //This creates a break for the switch statement.
                    case 1: //This tells the console what to display if the user puts in a 1.
                        Console.WriteLine("You have chosen: " + Integers[FavNum]); //This tells the user which number they chose.
                        ValidNum = true; //This sets the ValidNum boolean to true.
                        break; //This creates a break for the switch statement.
                    case 2: //This tells the console what to display if the user puts in a 2.
                        Console.WriteLine("You have chosen: " + Integers[FavNum]); //This tells the user which number they chose.
                        ValidNum = true; //This sets the ValidNum boolean to true.
                        break; //This creates a break for the switch statement.
                    case 3: //This tells the console what to display if the user puts in a 3.
                        Console.WriteLine("You have chosen: " + Integers[FavNum]); //This tells the user which number they chose.
                        ValidNum = true; //This sets the ValidNum boolean to true.
                        break; //This creates a break for the switch statement.
                    case 4: //This tells the console what to display if the user puts in a 4.
                        Console.WriteLine("You have chosen: " + Integers[FavNum]); //This tells the user which number they chose.
                        ValidNum = true; //This sets the ValidNum boolean to true.
                        break; //This creates a break for the switch statement.
                    default: //This tells the console what to display if the user puts in an invalid input.
                        Console.WriteLine("That is not a valid choice."); //This tells the user they did not make a valid choice.
                        Console.WriteLine("Which number do you choose? Please choose 0, 1, 2, 3, or 4: "); //This asks the user to choose a number.
                        FavNum = Convert.ToInt32(Console.ReadLine()); //This changes the FavNum integer to the user's new choice.
                        break; //This creates a break for the switch statement.
                }
            } while (!ValidNum); //This tells the console to repeat the loop as long as ValidNum is not true.

            List<string> Book = new List<string>(); //This defines the Books list
            Book.Add("King James Bible"); //This defines the element of the Books List at position 0.
            Book.Add("Heart of Darkness"); //This defines the element of the Books List at position 1.
            Book.Add("The Adventures of Huckleberry Finn"); //This defines the element of the Books List at position 2.
            Book.Add("A Brave New World"); //This defines the element of the Books List at position 3.
            Book.Add("1984"); //This defines the element of the Books List at position 4.

            Console.WriteLine("Which book do you choose? Please select 0, 1, 2, 3, or 4: ");
            int BookInt = Convert.ToInt32(Console.ReadLine()); //This converts the user's input to an integer
            bool ValidBookInt = BookInt < 5; //This establishes the ValidBookInt boolean for use with the do while loop for the message to display when a user puts in invalid input.

            do //This is the do while loop for when a user puts in invalid input.
            {
                switch (BookInt) //This establishes the switch statement with the BookInt Integer
                {
                    case 0: //This tells the console what to display if the user puts in a 0.
                        Console.WriteLine("You have chosen: " + Book[BookInt]); //This tells the user which book they chose.
                        ValidBookInt = true; //This sets the ValidBookInt boolean to true.
                        Console.ReadLine();
                        break; //This creates a break for the switch statement.
                    case 1: //This tells the console what to display if the user puts in a 1.
                        Console.WriteLine("You have chosen: " + Book[BookInt]); //This tells the user which book they chose.
                        ValidBookInt = true; //This sets the ValidBookInt boolean to true.
                        Console.ReadLine();
                        break; //This creates a break for the switch statement.
                    case 2: //This tells the console what to display if the user puts in a 2.
                        Console.WriteLine("You have chosen: " + Book[BookInt]); //This tells the user which book they chose.
                        ValidBookInt = true; //This sets the ValidBookInt boolean to true.
                        Console.ReadLine();
                        break; //This creates a break for the switch statement.
                    case 3: //This tells the console what to display if the user puts in a 3.
                        Console.WriteLine("You have chosen: " + Book[BookInt]); //This tells the user which book they chose.
                        ValidBookInt = true; //This sets the ValidBookInt boolean to true.
                        Console.ReadLine();
                        break; //This creates a break for the switch statement.
                    case 4: //This tells the console what to display if the user puts in a 4.
                        Console.WriteLine("You have chosen: " + Book[BookInt]); //This tells the user which book they chose.
                        ValidBookInt = true; //This sets the ValidBookInt boolean to true.
                        Console.ReadLine();
                        break; //This creates a break for the switch statement.
                    default: //This tells the console what to display if the user puts in an invalid input.
                        Console.WriteLine("That is not a valid choice."); //This tells the user they did not make a valid choice.
                        Console.WriteLine("Which book do you choose? Please choose 0, 1, 2, 3, or 4: "); //This asks the user to choose a book.
                        BookInt = Convert.ToInt32(Console.ReadLine()); //This changes the BookInt integer to the user's new choice.
                        break; //This creates a break for the switch statement.
                }
            } while (!ValidBookInt); //This tells the console to repeat the loop as long as ValidBookInt is not true.
        } 
    }
}
