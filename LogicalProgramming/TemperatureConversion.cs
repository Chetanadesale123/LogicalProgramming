using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class TemperatureConversion
    {
        public void CelToFeh()
        {
            float Fahrenheit, Celsius;
            Console.WriteLine("Enter the Temperature In Celcius ");
            Celsius = float.Parse(Console.ReadLine());

            Fahrenheit = (Celsius * 9.0f / 5.0f) + 32.0f;
            Console.WriteLine("Temperature in Celsius to Fahrenheit is : " + Fahrenheit);
        }
        public void FehToCel()
        {
            float Fahrenheit, Celsius;
            Console.WriteLine("Enter the Temperature In Fahrenheit ");
            Fahrenheit = float.Parse(Console.ReadLine());
            Celsius = (Fahrenheit - 32.0f) * 5.0f / 9.0f;
            Console.WriteLine("Temperature in Fahrenheit to Celsius is : " + Celsius);
        }
    }
}
    

