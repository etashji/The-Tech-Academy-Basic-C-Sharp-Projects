using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); //This instantiates the Employee class and creates the employee1 object.
            Employee employee2 = new Employee(); //This creates the employee 2 object.

            employee1.Id = 12345; //This defines the Id property for employee1.
            employee2.Id = 12345; //This defines the Id property for employee2.

            Console.WriteLine("It is:"); //This writes "It is:" to the console.
            Console.WriteLine(employee1 == employee2); //This determines whether the Id properties for employee1 and employee2 are the same.
            Console.WriteLine("that employee1 is equal to employee 2."); //This writes "that employee1 is equal to employee2."
            Console.ReadLine(); //This ensures the console stays open.
        }
    }
}
