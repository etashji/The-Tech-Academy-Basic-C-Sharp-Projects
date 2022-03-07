using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssigment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first lucky number?");//This asks the user for their first lucky number.
            string FirstLuckyNumber = Console.ReadLine(); //This assigns the user's input to the FirstLuckyNumber string.
            Console.WriteLine("What is your second lucky number?");//This asks the user for their second lucky number.
            string SecondLuckyNumber = Console.ReadLine(); //This assigns the user's input to the SecondLuckyNumber string.
            Console.WriteLine("What is your third lucky number?");//This asks the user for their third lucky number.
            string ThirdLuckyNumber = Console.ReadLine(); //This assigns the user's input to the ThirdLuckyNumber string.
            string PartOne = "Your lucky numbers are: " + FirstLuckyNumber +", "; //This creates the PartOne string
            string PartTwo = SecondLuckyNumber + ", and "; //This creates the PartTwo string
            string PartThree = ThirdLuckyNumber + "."; //This creates the PartThree string
            string String = string.Concat(PartOne + PartTwo + PartThree); //This concatenates the PartOne, PartTwo, and PartThree strings.
            Console.WriteLine(String); //This writes the String string.
            Console.ReadLine(); //This ensures the console stays open so the String string can be read.


            string Hello = "Hello!"; //This defines the Hello string
            Console.WriteLine(Hello.ToUpper()); //This writes the Hello string as all uppercase
            Console.ReadLine(); //This ensures the console stays open so the Hello string can be read.


            StringBuilder sb = new StringBuilder(); //This defines the stringbuilder sb.
            sb.Append("\tThis is the first sentence of my paragraph. "); //This appends the stringbuilder with the first sentence of the paragraph.
            sb.Append("This is the second sentence of my paragraph. "); //This appends the stringbuilder with the second sentence of the paragraph.
            sb.Append("This is the third sentence of my paragraph. ");//This appends the stringbuilder with the third sentence of the paragraph.
            sb.Append("This is the fourth sentence of my paragraph. ");//This appends the stringbuilder with the fourth sentence of the paragraph.
            sb.Append("This is the fifth sentence of my paragraph. ");//This appends the stringbuilder with the fifth sentence of the paragraph.
            Console.WriteLine(sb); //This writes the sb stringbuilder
            Console.ReadLine(); //This ensures the console stays open so the Hello string can be read.
        }
    }
}
