using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Joe = new Employee(); //This creates the Joe object.
            Joe.firstName = "Joe"; //This sets the firstName property for the Joe object.
            Joe.lastName = "Manchin"; //This sets the lastName property for the Joe object.
            Joe.Id = 1; //This sets the Id property for the Joe object.

            Employee Russia = new Employee(); //This creates the Russia object.
            Russia.firstName = "Joe"; //This sets the firstName property for the Russia object.
            Russia.lastName = "Stalin"; //This sets the lastName property for the Russia object.
            Russia.Id = 1917; //This sets the Id property for the Russia object.

            Employee England = new Employee(); //This creates the England object.
            England.firstName = "Winston"; //This sets the firstName property for the England object.
            England.lastName = "Churchill"; //This sets the lastName property for the England object.
            England.Id = 1939; //This sets the Id property for the England object.

            Employee America = new Employee(); //This creates the America object.
            America.firstName = "Franklin"; //This sets the firstName property for the America object.
            America.lastName = "Roosevelt"; //This sets the lastName property for the America object.
            America.Id = 1776; //This sets the Id property for the America object.

            Employee France = new Employee(); //This creates the France object.
            France.firstName = "Charles"; //This sets the firstName property for the France object.
            France.lastName = "Gaul"; //This sets the lastName property for the France object.
            France.Id = 0; //This sets the Id property for the France object.

            Employee Germany = new Employee(); //This creates the Germany object.
            Germany.firstName = "Erwin"; //This sets the firstName property for the Germany object.
            Germany.lastName = "Rommel"; //This sets the lastName property for the Germany object.
            Germany.Id = 1930; //This sets the Id property for the Germany object.

            Employee India = new Employee(); //This creates the India object.
            India.firstName = "Archibald"; //This sets the firstName property for the India object.
            India.lastName = "Wavell"; //This sets the lastName property for the India object.
            India.Id = 2; //This sets the Id property for the India object.

            Employee Australia = new Employee(); //This creates the Australia object.
            Australia.firstName = "John"; //This sets the firstName property for the Australia object.
            Australia.lastName = "Curtin"; //This sets the lastName property for the Australia object.
            Australia.Id = 3; //This sets the Id property for the Australia object.

            Employee Japan = new Employee(); //This creates the Japan object.
            Japan.firstName = "Hideki"; //This sets the firstName property for the Japan object.
            Japan.lastName = "Hirohito"; //This sets the lastName property for the Japan object.
            Japan.Id = 1941; //This sets the Id property for the Japan object.

            Employee China = new Employee(); //This creates the China object.
            China.firstName = "Chang"; //This sets the firstName property for the China object.
            China.lastName = "Kaishek"; //This sets the lastName property for the China object.
            China.Id = 4; //This sets the Id property for the China object.

            List<Employee> Employees = new List<Employee>() //This estaglishes the Employees list.
            {
                Joe, Russia, England, America, France, Germany, India, Australia, Japan, China
            };
            foreach (Employee employee in Employees) //This creates the foreach loop for each employee in the Employees list.
            {
                if (employee.firstName == "Joe") //This deterimes if the first name of each employee is joe.
                {
                    Console.WriteLine(employee.firstName + " " + employee.lastName); //This prints the employee's name to the console if their name is Joe.
                }
            }

            List<Employee> newEmployees = Employees.Where(x => x.firstName == "Joe").ToList(); //This uses a lambda expression to create a list of Employees from the Employees list where the Employee's first name is joe.
            foreach (Employee employee in newEmployees) //This creates a foreach loop for the employees in our new list.
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName); //This prints the employee's name to the console if their first name is joe.
            }

            List<Employee> EmployeeIds = Employees.Where(x => x.Id > 5).ToList(); //This uses a lambda expression to create a new list from the Employees list where the employees id is less than 5.
            foreach (Employee employee in EmployeeIds) //This creates a foreach loop for our EmployeeIds list.
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.Id); //This writes the employee's name and their Id to the console if their Id is greater than 5.
            }

            Console.ReadLine(); 
        }
    }
}
