using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class ZeroNegativeException : Exception //This instantiates the ZeroNegativeException class and has it inherit from the Exception class.
    {
        public ZeroNegativeException()
            : base() { }
        public ZeroNegativeException(string message)
            : base(message) { }
    }
}
