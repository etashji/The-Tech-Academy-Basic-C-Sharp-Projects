using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignmnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your number?");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Eric Tashji\Logs\input.txt", "Your number is: " + text);
            Console.WriteLine(File.ReadAllText(@"C:\Users\Eric Tashji\Logs\input.txt"));
            Console.ReadLine();
        }
    }
}
