using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class FibonacciSeries
    {
        public void Fibo()
        {
            int num, i, a = -1, b = 1, c;
            Console.WriteLine("Enter how many terms of fibonacci series you want to see :");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
        public void Rfibo()
        {
            int i, n;

            Console.WriteLine("Enter how many terms of fibonacci series you want to see with Recursion :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {

                Console.WriteLine(Rfibonacci(i));
            }
        }
        int Rfibonacci(int i)
        {
            if (i == 1) return 0;
            else if (i == 2)
                return 1;
            else return (Rfibonacci(i - 1) + Rfibonacci(i - 2));
        }
    }
}
    

