using System;
namespace LogicalProgramming;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Logical Programs");
        bool end = true;
        Console.WriteLine("1.Fibonacci series\n 2.Perfect No\n 3.Prime Number\n 4.Reverse a no \n 5 Return Notes\n 6.Day of Week\n 7.Temperature Conversion\n 8. End the Program");
        while (end == true)
        {
            Console.WriteLine("Take an option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries fibo = new FibonacciSeries();
                    fibo.Fibo();
                    fibo.Rfibo();
                    break;
                case 2:
                    PerfectNo perfectNo = new PerfectNo();
                    perfectNo.Perfect();
                    break;
                case 3:
                    PrimeNo primeNo = new PrimeNo();
                    primeNo.Prime();
                    break;
                case 4:
                    ReverseNo revNo = new ReverseNo();
                    revNo.Reverse();
                    break;
                case 5:
                    Notes notes = new Notes();
                    notes.ReturnNotes();
                    break;
                case 6:
                    DayOfWeek day = new DayOfWeek();
                    day.Day();
                    break;
                case 7:
                    TemperatureConversion conv = new TemperatureConversion();
                    conv.CelToFeh();
                    conv.FehToCel();
                    break;
                case 8:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Enter Proper Option To Execute");
                    break;
            }
        }
    }
}