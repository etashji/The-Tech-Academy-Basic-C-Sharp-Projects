using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string constVariable = "This is my constant variable."; //This creates the constant string constVariable.
            Console.WriteLine(constVariable); //This writes the constVariable to the console.

            var variable = "This is my var variable."; //This creates the variable variable.
            Console.WriteLine(variable); //This writes the variable to the console.

            Employee employee = new Employee("Eric"); //This creates a new Employee object named employee.
            Console.WriteLine("The employee's name is {0}.", employee.Name); //This write's the employee's name to the console.
            Console.WriteLine("The employee's ID is {0}.", employee.Id); //This writes the employee's ID to the console.
            Console.ReadLine();
        }

        public class Employee //This creates the Employee class.
        {
            public Employee(string name) : this(name, 1) //This chains the Employee class so that the Employee's ID is 1 by default.
            {

            }

            public Employee(string name, int id) //This specifies the properties of the Employee class.
            {
                Name = name; //This instantiates that the Name property is the same as the name string.
                Id = id; //THis instantiates the Id property is the same as the id integer.
            }

            public string Name { get; set; } //This instantiates the Name property.
            public int Id { get; set; } //This instantiates the Id integer.
        }
    }
}
