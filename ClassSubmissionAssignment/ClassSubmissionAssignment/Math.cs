using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Math
    {
        public void Division(int input)
        {
            Console.WriteLine(input / 2);
            return;
        }

        public int Division(int input1, int input2)
        {
            int answer = input1 / input2;
            return answer;
        }

        public void Output(out int Output1, out int Output2)
        {
            Output1 = 44;
            Output2 = 45;
        }

        public static void Static()
        {
            Console.WriteLine("This is my static class.");
        }
        public void Static2()
        {
            Static();
        }
    }
}
