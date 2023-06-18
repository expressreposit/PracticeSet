using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class StaticVsSingletonClass
    {
        static void Main1(string[] args) 
        {
            double celcius = 37;
            double fahrenheit = 98.6;
            Console.WriteLine("Value of {0} celcius to fahrenheit is {1}", celcius, Converter.ToFahrenheit(celcius));
            Console.WriteLine("Value of {0} fahrenheit to celcius is {1}", fahrenheit, Converter.ToCelcius(fahrenheit));

            Console.ReadLine();
        }
    }
    public static class Converter
    {
        public static double ToFahrenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }
        public static double ToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
/*
    Exception/Information logging
    Connection pool management 
    File management
    Device management such as printer spooling
    Application Configuration management
    Cache management
    And Session based shopping cart are some of the real world usage of singleton design pattern.
 */
