using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee(); //This instantiates the employee class.

            employee.firstName = "Sample"; //This defines the firstName property for the employee object.
            employee.lastName = "Student"; //This defines the lastName property for the employee object.
            employee.Quit(); //This implements the Quit() method on the employee object.
            Console.ReadLine(); //This ensures the console stays open.
        }
    }
}
