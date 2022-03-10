using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //This instantiates the employee object.
            employee.firstName = "Sample"; //This defines the firstName property of the employee object.
            employee.lastName = "Student"; //This defines the lastName property of the employee object.
            employee.SayName(); //This implements the employee.SayName() method.
            Console.ReadLine(); //This ensures the console stays open.
        }
    }
}
