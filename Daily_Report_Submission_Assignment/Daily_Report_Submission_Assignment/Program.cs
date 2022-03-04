using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The Tech Academy \nStudent Daily Report \nWhat is your name? ");
            string Name = Convert.ToString(Console.ReadLine());

            Console.Write("What course are you on? ");
            string Course = Convert.ToString(Console.ReadLine());

            Console.Write("What page number? ");
            int Page = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you need help with anything? Please answer \"true\" or \"false.\" ");
            bool Help = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Were there any positive experiences you'd like to share? Please give specifics. ");
            string Experience = Convert.ToString(Console.ReadLine());

            Console.Write("Is there any other feedback you'd like to provide? Please be specific. ");
            string Feedback = Convert.ToString(Console.ReadLine());

            Console.Write("How many hours did you study today? 8");
            int Hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
