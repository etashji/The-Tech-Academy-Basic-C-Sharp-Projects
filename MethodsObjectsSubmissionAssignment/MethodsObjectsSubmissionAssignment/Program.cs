using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee(); //This instantiates the Employee class.
            Employee.FirstName = "Sample"; //This defines the FirstName property of the Employee object.
            Employee.LastName = "Student"; //This defines the LastName property of the Employee object.
            Employee.Id = 11111;//This defines the Id property of the Employee object.
            Employee.SayName(); //This implements the SayName() method.
            Employee.SayID(); //This implements the SayID() method.
            Console.ReadLine(); //This ensures the console stays open.
        }
    }
}
