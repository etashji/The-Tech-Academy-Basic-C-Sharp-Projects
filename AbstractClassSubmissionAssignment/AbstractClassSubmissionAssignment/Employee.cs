using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
   public class Employee : Person
    {
        public void SayName() //This implements the SayName() method.
        {
            Console.WriteLine("Name: [" + firstName + " " + lastName + "]"); //This ensures the console writes: Name:[firstName lastName].
        }
    }
}
