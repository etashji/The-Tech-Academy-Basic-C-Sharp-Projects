using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Math
    {
        public int PlusOne(int input) //This creates the PlusOne method and assigns it the input integer.
        {
            int answer = input + 1; //This creates the answer integer by adding 1 to the input integer.
            return answer; //This ensures the method returns the answer integer.
        }
        public int PlusOne(decimal decimals) //This creates the PlusOne method and assigns it the decimals decimal.
        {
            decimal answer = decimal.Add(decimals, 1.0m); //This creates the answer decimal by adding 1 to the decimals decimal.
            return Convert.ToInt32(answer); //This ensures the method returns the answer integer.
        }
        public int PlusOne(string strings) //This creates the PlusOne method and assigns it the strings string.
        {
            int integer = Convert.ToInt32(strings); //This converts the strings string to an integer.
            int answer = integer + 1; //This creates the answer integer by adding 1 to the integer integer.
            return answer; //This ensures the method returns the answer integer.
        } 
    }
}
