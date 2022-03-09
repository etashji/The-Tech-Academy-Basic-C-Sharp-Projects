using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
                Math math = new Math();
                Console.WriteLine("What is your first number? ");
                int input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your second number? Note: this number is optional.");
                int input2 = Convert.ToInt32(Console.ReadLine());


                int answer = math.Addition(input1); 
                Console.WriteLine(answer);
                Console.ReadLine();
        }
    }
}
