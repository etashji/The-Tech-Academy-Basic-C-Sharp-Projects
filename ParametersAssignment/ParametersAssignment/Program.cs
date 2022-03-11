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
            employee1.Things = new List<string>();
            employee1.Things.Add("Hello");
            employee1.Things.Add("Goodbye");

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>();
            employee2.Things.Add(1);
            employee2.Things.Add(2);

            foreach (string i in employee1.Things)
            {
                Console.WriteLine(i);
            }
            foreach (int i in employee2.Things)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
