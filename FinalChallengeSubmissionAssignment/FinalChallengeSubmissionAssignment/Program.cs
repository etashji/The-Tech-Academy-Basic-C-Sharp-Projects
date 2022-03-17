using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace FinalChallengeSubmissionAssignment
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Please enter the student's first name: ");
                var firstName = Console.ReadLine();

                Console.WriteLine("Please enter the student's last name: ");
                var lastName = Console.ReadLine();

                var student = new Students { FirstName = firstName, LastName = lastName };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from b in db.Students
                            orderby b.LastName
                            select b;
                Console.WriteLine("All students in the database: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
