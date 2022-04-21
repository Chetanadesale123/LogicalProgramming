using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class CouponNumbers
    {
        public void CouponNo()
        {
            int count = 0, n;
            Console.WriteLine("Enter the  coupon number");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                Random random = new Random();
                int check = random.Next(1, 99);
                if (check == n)//21!=25 25==25
                {
                    Console.WriteLine("Congrats!!got the coupon number in first attempt");
                    break;
                }
                count++;//1 2
                Console.WriteLine("count to get coupon number is:" + count);
               // n--;
            }
            Console.WriteLine("to get distinct coupon number the number of times random number used:" + count);//total no of count=2

        }
    }
}












