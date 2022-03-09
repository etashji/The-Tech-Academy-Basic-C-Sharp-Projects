using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                List<int> integerList = new List<int>() { 4, 6 };
                Console.WriteLine("What number would you like to divide 4 and 6 by?");
                int response = Convert.ToInt32(Console.ReadLine());

                foreach (int integer in integerList)
                {
                    Console.WriteLine("Four and six divided by " + response + " equals " + integer / response);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a NUMBER!");
                return;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
