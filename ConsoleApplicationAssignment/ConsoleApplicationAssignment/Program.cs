using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("What number would you like to multiply times 50?");//This asks the user for their number
           int  YourNumber = Convert.ToInt32(Console.ReadLine());//This converts their number to a variable
           Console.Write("Your number times 50 = " + YourNumber * 50);//This prints their number and performs an operation with it
           Console.ReadLine();//This makes the console display the new number.

           Console.WriteLine("What number would you like to add 25 to?");//This asks the user for their number
           int YourNumber2 = Convert.ToInt32(Console.ReadLine());//This converts their number to a variable
           Console.WriteLine("Your number plus 25 = " + (YourNumber2 + 25));//This prints their number and performs an operation with it
            Console.ReadLine();//This makes the console display the new number.

            Console.WriteLine("What number would you like to divide by 12.5?");//This asks the user for their number
            double YourNumber3 = Convert.ToDouble(Console.ReadLine());//This converts their number to a variable
            Console.WriteLine("Your number divided by 12.5 = " + YourNumber3 / 12.5);//This prints their number and performs an operation with it
            Console.ReadLine();//This makes the console display the new number.

           Console.WriteLine("What number would you like to check to see if it is greater than 50? ");//This asks the user for their number
           int YourNumber4 = Convert.ToInt32(Console.ReadLine());//This converts their number to a variable
           bool greater = YourNumber4 > 50; //This establishes a boolean to check and see if the number is greater than 50
           Console.WriteLine("Your number is greater than 50 = " + greater); //This answers whether the number is greater than 50
           Console.ReadLine(); //This displays the question

           Console.WriteLine("What number would you like to take the remainder of after dividing it by 7? ");//This asks the user for their number
           int YourNumber5 = Convert.ToInt32(Console.ReadLine());//This converts their number to a variable
           Console.WriteLine("The remainder after dividing your number by 7 = " + YourNumber5 % 7);//This prints their number and performs an operation with it
           Console.ReadLine();//This makes the console display the new number.
        }
    }
}
