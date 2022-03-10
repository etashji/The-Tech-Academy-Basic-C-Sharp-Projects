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
            Employee Employee = new Employee();
            Employee.FirstName = "Sample";
            Employee.LastName = "Student";
            Employee.Id = 11111;
            Employee.SayName();
            Employee.SayID();
            Console.ReadLine();
        }
    }
}
