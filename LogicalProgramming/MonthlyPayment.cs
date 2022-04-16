using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class MonthlyPayment
    {
        public void Payment()
        {
            double payment, PrincipalAmount, r, n, Rate;
            int years;
            Console.WriteLine("Enter the years");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the PrincipalAmount");
            PrincipalAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the CompoundInterest Rate ");
            Rate = Convert.ToDouble(Console.ReadLine());
            n = 12 * years;
            r = (Rate) / (12 * 100);
            payment = ((PrincipalAmount * r) / (1 - Math.Pow((1 + r), -n)));
            Console.WriteLine("Monthly Payment :" + payment);
        }
    }
}

