using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the current day of the week?");
            string day = Console.ReadLine();
            Enum.Parse()
            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
