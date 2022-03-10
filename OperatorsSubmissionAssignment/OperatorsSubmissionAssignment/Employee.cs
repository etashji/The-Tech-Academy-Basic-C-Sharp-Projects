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

        public override bool Equals(object obj) //This is an override so the == operator can be overloaded by Employee.
        {
            return Equals(obj as Employee); //This works with the above statement.
        }


        public override int GetHashCode() //This overrides the GetHashCode so the == operater can be overloaded by Employee.
        {
            return 2108858624 + Id.GetHashCode(); //This provides a default number to assist the above statement.
        }

        public static Employee operator== (Employee employee1, Employee employee2) //This overloads the == operator.
        {
            employee1.Id.Equals(employee2.Id); //This displays whether the Id for employee1 and employee2 are true.
            return employee1; //This returns the result.
        }

        public static Employee operator != (Employee employee1, Employee employee2) //This overloads the != operator.
        {
            employee1.Id.Equals(employee2.Id); //This displays whether the id for employee1 and employee2 are equal.
            return employee1; //This returns the result.
        }
    }
}
