using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsSubmissionAssignment
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public void SayID()
        {
            Console.WriteLine("ID: [" + Id + "]");
        }
    }
}
