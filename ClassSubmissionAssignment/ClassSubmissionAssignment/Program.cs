using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please ente a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            int Output1 = 0;
            int Output2 = 0;
            int input1 = 8;
            int input2 = 4;
            
            Console.WriteLine("Your number divided by 2 equals: ");
            math.Division(input);

            Console.WriteLine("My output parameters are: ");
            math.Output(out Output1, out Output2);
            Console.WriteLine(Output1 + " and " + Output2);

            Console.WriteLine("The difference in my overloaded method is: ");
            Console.WriteLine(math.Division(input1, input2));

            Console.WriteLine("The output for my static class is: ");
            Static.Method();

            Console.ReadLine();
        }   

    }
   
}
