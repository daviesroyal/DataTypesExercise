using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of your rectangle?");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of your rectangle?");
            int width = int.Parse(Console.ReadLine());
            int area = width * length;
            Console.WriteLine("The area of your rectangle is " + area);
        }
    }
}
