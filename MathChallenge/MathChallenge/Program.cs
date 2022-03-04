using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = 5;
            decimal num2 = 7;
            decimal addition = num1 + num2;
            decimal subtraction = num2 - num1;
            decimal multiplication = num1 * num2;
            decimal division = num1 / num2;
            Console.WriteLine(addition);
            Console.WriteLine(subtraction);
            Console.WriteLine(multiplication);
            Console.WriteLine(division);
            Console.WriteLine("Hello" + "World!");

            Console.Read();
        }
    }
}
