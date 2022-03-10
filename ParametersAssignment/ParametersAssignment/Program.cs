using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things.Add("Hello");
            employee1.Things.Add("Goodbye");

            Employee<int> employee2 = new Employee<int>();
            List<int> things2 = employee2.Things;
            employee2.Things.Add(1);
            employee2.Things.Add(2);
        }
    }
}
