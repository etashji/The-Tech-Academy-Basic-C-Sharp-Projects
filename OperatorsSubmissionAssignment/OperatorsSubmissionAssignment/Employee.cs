using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    public class Employee
    {
        public string firstName { get; set; } //This sets the firstName property for the Employee class.
        public string lastName { get; set; } //This sets the lastName property for the Employee class.

        public int Id { get; set; } //This sets the Id property in the Employee class.

        public static bool operator== (Employee employee1, Employee employee2) //This overloads the == operator.
        {
            bool result = employee1.Id == employee2.Id; //This displays whether the Id for employee1 and employee2 are true.
            return result; //This returns the result.
        }

        public static bool operator != (Employee employee1, Employee employee2) //This overloads the != operator.
        {
            bool result = employee1.Id != employee2.Id; //This displays whether the id for employee1 and employee2 are equal.
            return result;
        }
    }
}
