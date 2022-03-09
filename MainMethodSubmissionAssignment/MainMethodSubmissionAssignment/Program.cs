using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); //This instantiates the class
            
            int input = 1; //This creates the input integer
            int answer =  math.PlusOne(input); //This asks the console to perform the PlusOne method from the math Math class on the input integer and assigns it to the answer integer.
            Console.WriteLine(answer); //This asks the console to display the answer integer.

            decimal decimals = 0.5m; //This creates the decimals decimal
            int answer2 = math.PlusOne(decimals);//This asks the console to perform the PlusOne method from the math Math class on the decimals decimal and assigns it to the answer2 integer.
            Console.WriteLine(answer2); //This asks the console to display the answer integer.

            string strings = "1"; //This creates the strings string.
            int answer3 = math.PlusOne(strings); //This asks the console to perform the PlusOne method from the math Math class on the strings string and assigns it to the answer3 integer.
            Console.WriteLine(answer3); //This asks the console to display the answer integer.

            Console.ReadLine(); //This ensures the console stays open.
        }
    }
}
