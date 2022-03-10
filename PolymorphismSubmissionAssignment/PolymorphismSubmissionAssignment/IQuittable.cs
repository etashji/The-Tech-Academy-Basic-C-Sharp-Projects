using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    interface IQuittable
    {
        string firstName { get; set; } //This defines the firstName property for the IQuittable class.
        string lastName { get; set; } //This defines the lastName property for the IQuittable class.
        void Quit(); //This instantiates the Quit() method.
    }
}
