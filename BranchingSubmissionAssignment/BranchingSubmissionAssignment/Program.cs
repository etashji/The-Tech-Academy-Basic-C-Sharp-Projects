using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");//This is the introductory line
            Console.WriteLine("Please enter the package weight:");//This asks the user for the package weight
            double weight = Convert.ToDouble(Console.ReadLine());//This assigns the user's input to a double

            if (weight > 50)//This establishes the if statement for if weight is greater than 50
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");//This displays if weight is greater than 50.
                Console.ReadLine();//This ensures the console displays
            }
            else//This says what to do if the weight is not greater than 50.
            {
                Console.WriteLine("Please enter the package width: "); //This asks the user for their package width
                double width = Convert.ToDouble(Console.ReadLine()); //This assigns the user's input to a double

                Console.WriteLine("Please enter the package height: "); //This asks the user for their package height
                double height = Convert.ToDouble(Console.ReadLine()); //This assigns the user's input to a double

                Console.WriteLine("Please enter the package length: "); //This asks the user for their package length
                double length = Convert.ToDouble(Console.ReadLine()); //This assigns the user's input to a double

                double dimensions = width + height + length; //This adds the dimensions together
                if (dimensions > 50) //This establishes the if statement for if the total dimensions are more than 50
                {
                    Console.WriteLine("Package too big to be shipped via Package Express."); //This displays if the total dimensions are greater than 50
                    Console.ReadLine(); //This ensures the console displays
                }
                else //This shows what to do if the total dimensions are not greater than 50
                {
                    double priceDimensions = width * height * length; //This multiplies the dimensions together
                    double packageCost = priceDimensions * weight;//This multiplies the product of the dimensions by the weight
                    double cost = packageCost / 100;//This divides the wight by 100
                    Console.WriteLine("Your estimated total for this package is: $" + cost);//This displays the total cost
                    Console.WriteLine("Thank you!"); //This is the closing statement
                    Console.ReadLine();//This ensures the console is displayed.
                }
            }
        }
    }
}
