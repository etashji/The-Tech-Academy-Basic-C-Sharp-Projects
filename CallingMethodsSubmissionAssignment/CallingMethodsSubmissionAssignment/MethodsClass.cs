using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmissionAssignment
{
    public class MethodsClass
    {
        public int PlusOne(int input) //This declares the PlusOne method with the input integer
        {
            int answer = input + 1; //This creates the answer integer by adding 1 to the input integer.
            return answer; //This returns the answer integer.
        }
        public int MinusOne(int input) //This declares the MinusOne method with the input integer
        {
            int answer = input - 1; //This creates the answer integer by subtracting 1 from the input integer.
            return answer;//This returns the answer integer.
        }
        public int TimesTen(int input) //This declares the MinusOne method with the input integer
        {
            int answer = input * 10; //This creates the answer integer by multiplying 10 times the input integer.
            return answer; //This returns the answer integer.
        }
    }
    
}
