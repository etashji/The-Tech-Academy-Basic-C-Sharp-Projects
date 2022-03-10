using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsSubmissionAssignment
{
    public class Employee : Person
    {
        public int Id { get; set; } //This creates the Id property.

        public void SayID() //This implements the SayID() property.
        {
            Console.WriteLine("ID: [" + Id + "]"); //This ensures the console reads "ID: [Id]."
        }
    }
}
