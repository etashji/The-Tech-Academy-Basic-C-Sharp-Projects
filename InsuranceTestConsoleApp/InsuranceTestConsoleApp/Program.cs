using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Insurees insuree = new Insurees();

            Console.WriteLine("What is your first name?");
            insuree.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            insuree.Lastname = Console.ReadLine();

            Console.WriteLine("What is your email address?");
            insuree.EmailAddress = Console.ReadLine();

            Console.WriteLine("What is your date of birth? (mm/dd/yyyy)");
            insuree.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("What is your car year?");
            insuree.CarYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your car make?");
            insuree.CarMake = Console.ReadLine();

            Console.WriteLine("What is your car model?");
            insuree.CarModel = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? (Please write 'true' if true, 'false' if false.");
            insuree.DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            insuree.SpeedingTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you want full coverage? (Please write 'true' if true, 'false' if false.");
            insuree.CoverageType = Convert.ToBoolean(Console.ReadLine());

            insuree.Quote = 50;
            bool hadBirthdayMonth = false;
            bool hadBirthdayDay = false;
            int insureeAge = 0;
            if (insuree.DateOfBirth.Month < DateTime.Now.Month)
            {
                hadBirthdayMonth = true;
            }
            if (insuree.DateOfBirth.Day < DateTime.Now.Day)
            {
                hadBirthdayDay = true;
            }
            if (hadBirthdayDay == true && hadBirthdayMonth == true)
            {
                insureeAge = insuree.DateOfBirth.Year - DateTime.Now.Year;
            }
            else
            {
                insureeAge = insuree.DateOfBirth.Year - DateTime.Now.Year - 1;
            }
            if (insureeAge <= 18)
            {
                insuree.Quote += 100;
            }
            else if (insureeAge < 19 && insureeAge > 25)
            {
                insuree.Quote += 50;
            }
            else
            {
                insuree.Quote += 25;
            }
            if (insuree.CarYear < 2000)
            {
                insuree.Quote += 25;
            }
            else if (insuree.CarYear > 2015)
            {
                insuree.Quote += 25;
            }
            if (insuree.CarMake == "Porsche")
            {
                insuree.Quote += 25;

                if (insuree.CarModel == "911 Carrera")
                {
                    insuree.Quote += 25;
                }
            }
            insuree.Quote += insuree.SpeedingTickets * 10;
            if (insuree.DUI == true)
            {
                decimal.Multiply(insuree.Quote, 1.25m);
            }
            if (insuree.CoverageType == true)
            {
                decimal.Multiply(insuree.Quote, 1.5m);
            }

            Console.WriteLine("Your quote is: $" + insuree.Quote + ".");
            Console.ReadLine();
        }
    }
}
