using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven so far?");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons of gas have you used?");
            double gallons = double.Parse(Console.ReadLine());
            double mpg = miles / gallons;
            Console.WriteLine("Your mpg for this trip is " + mpg);
        }
    }
}
