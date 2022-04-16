using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class StopwatchProgram
    {
        public void StopWatch()
        {


            Console.WriteLine("Enter String");

            ////Reads input string from the user 
            String str = Console.ReadLine();

            ////Creating object of an predefined class to access its functionalities
            TimeSpan timespan = TimeSpan.Zero;

            ////Call to the functionalities
            int hour = timespan.Hours;
            int min = timespan.Minutes;
            int sec = timespan.Seconds;
            int milsec = timespan.Milliseconds;
            if (str.Equals("s"))
            {

                ////Read another string to end the program
                String str1 = Console.ReadLine();

                ////Condition to stop
                if (str1.Equals("e"))
                {
                    Console.WriteLine("Program stopped");

                    ////Accesing the functionalities

                    int hour1 = timespan.Hours;
                    int min1 = timespan.Minutes;
                    int sec1 = timespan.Seconds;
                    int milsec1 = timespan.Milliseconds;
                    Console.WriteLine(milsec1);
                    Console.WriteLine("total time taken:" + "hours:" + (hour1 - hour) + " " + "minutes:" + (min1 - min) + " " + "seconds:" + (sec1 - sec));

                    ////Print the time in the format of 00:00:00
                    Console.WriteLine(timespan.ToString());
                }
                else
                {
                    Console.WriteLine("Enter correct charecter to stop");
                }
            }
            else
            {
                Console.WriteLine("Enter correct charecter to start");
            }
        }
    }
}




