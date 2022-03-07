using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisonOperatorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //This is the opening line
            
            Console.WriteLine("Person 1"); //This writes Person 1
            Console.WriteLine("Hourly Rate?"); //This asks the user for their hourly rate
            double HourlyRate1 = Convert.ToDouble(Console.ReadLine()); //This converts the user's input to a double.
            Console.WriteLine("Hours Worked per week?"); //This asks the user for their hours worked per week.
            double HoursWorked1 = Convert.ToDouble(Console.ReadLine()); //This converts the user's input to a double.

            Console.WriteLine("Person 2"); //This writes Person 2
            Console.WriteLine("Hourly Rate?"); //This asks the user for their hourly rate
            double HourlyRate2 = Convert.ToDouble(Console.ReadLine()); //This converts the user's input to a double.
            Console.WriteLine("Hours worked per week?"); //This asks the user for their hours worked per week.
            double HoursWorked2 = Convert.ToDouble(Console.ReadLine());//This converts the user's input to a double.

            Console.WriteLine("Annual Salary of Person 1:"); //This displays the annual salary of person 1 header
            double AnnualSalary1 = HourlyRate1 * HoursWorked1 * 52; //This determines Person 1's annual salary.
            Console.WriteLine(AnnualSalary1); //This displays Person 1's annual salary.
          

            Console.WriteLine("Annual Salary of Person 2: "); //This displays the annual salary of person 2 header
            double AnnualSalary2 = HourlyRate2 * HoursWorked2 * 52; //This determines Person 2's annual salary.
            Console.WriteLine(AnnualSalary2); //This displays Person 2's annual salary.

            bool SalaryComparison = AnnualSalary1 > AnnualSalary2; //This compares both persons' annual salaries.
            Console.WriteLine("Does Person 1 make more money than Person 2?"); //This asks whether person 1 makes more than person 2.
            Console.WriteLine(SalaryComparison); //This displays whether person 1 makes more than person 2
            Console.ReadLine(); //This ensures the console stays open.
        }
    }
}
