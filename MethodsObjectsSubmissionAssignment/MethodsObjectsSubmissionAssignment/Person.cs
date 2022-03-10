using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsSubmissionAssignment
{
    public class Person
    {
        public string FirstName { get; set; } //This creates the FirstName property.
        public string LastName { get; set; } //This creates the LastName property.

        public void SayName() //This implements the SayName() method.
        {
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");//This ensures the console prints "Name:[FirstName LastName]."
        }
    }
}
