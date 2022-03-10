using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public abstract class Person
    {
        public string firstName { get; set; } //This establishes the firstName property.
        public string lastName { get; set; } //This establishes the lastName property.

        public void SayName() //This creates the SayName() method.
        {
            Console.WriteLine("Name: [" + firstName + " " + lastName + "]");//This has the console write: Name:[firstName lastName]
        }
    }
}
