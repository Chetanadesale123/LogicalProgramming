using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class ReverseNo
    {
        public void Reverse()
        {
            int num, rev = 0, rem;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse is" + " " + rev);
        }
    }
}

