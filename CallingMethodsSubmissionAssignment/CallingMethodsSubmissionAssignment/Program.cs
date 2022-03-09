using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which number would you like to use?"); //This asks the user what number they would like to use.
            int input = Convert.ToInt32(Console.ReadLine()); //This saves the user's input as the input integer.
            MethodsClass class1 = new MethodsClass(); //This creates the class1 MethodsClass.

            int addition = class1.PlusOne(input); //This declares the addition integer by using the PlusOne method from the class1 MethodsClass class.
            int subtraction = class1.MinusOne(input); //This declares the subtraction integer by using the MinusOne method from the class1 MethodsClass class.
            int multiplication = class1.TimesTen(input); //This declares the multiplication integer by using the TimesTen method from the class1 MethodsClass class.
            Console.WriteLine(input + " plus one " + "equals " + addition); //This displays the answer from the PlusOne method.
            Console.WriteLine(input + " minus one " + "equals " + subtraction); //This displays the answer from the MinusOne method.
            Console.WriteLine(input + " times ten " + "equals " + multiplication); //This displays the answer from the TimesTen method.
            Console.ReadLine();//This ensures the console stays open.

        }
        
    }
}
