using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); //This instantiates the math class as a Math class.
            int integer1 = 1; //This declares and defines the integer integer1.
            int integer2 = 2; //This declares and defines the integer integer2.

            math.Addition(1, 2); //This performs the math.Addition method with the parameter of 1 and 2.
            math.Addition(integer1, integer2); //This performs the math.Addition method with the parameter of integer1 and integer2
            Console.ReadLine();//This ensures the console stays open.
        }
    }
}
