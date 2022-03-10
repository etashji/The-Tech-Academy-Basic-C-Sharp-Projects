using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    class Employee: IQuittable
    {
        public string firstName { get; set; } //This defines the firstName property for the Employee class.
        public string lastName { get; set; } //This defines the lastName property for the Employee class.

        public void Quit() //This instantiates the Quit() method.
        {
            Console.WriteLine(firstName + " " + lastName + " has quit."); //This ensures the console reads: "firstName lastName has quit."
        }
    }
}
