using System;
using System.Runtime.InteropServices;

namespace AlterRechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen beim Alter Berechner!");
            
            var calculator = new AgeCalculator();
            calculator.CalculateAge();
        }
    }
}
