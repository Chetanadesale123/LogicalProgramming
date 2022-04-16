using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class PrimeNo
    {
        public void Prime()
        {
            int num, i;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= num - 1; i++)
            {
                if (num % i == 0)
                    break;
            }
            if (i == num)
                Console.WriteLine(num + " " + "is a prime number");
            else
                Console.WriteLine(num + " " + "is not a prime number");
        }
    }
}

