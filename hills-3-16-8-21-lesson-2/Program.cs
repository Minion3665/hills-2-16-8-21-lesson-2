using System;

namespace hills_3_16_8_21_lesson_2
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Program to calculate the circumference of a circle");
            Console.Write("Enter circle radius: ");
            
            double radius;
            while (!double.TryParse(Console.ReadLine(), out radius))
            {
                Console.Write("That wasn't a number, please try again: ");
            }

            var circumference = radius * Math.Tau; // (The formula for the circumference of a circle is the radius times tau (tau is equal to 2 pi))

            Console.WriteLine($"The circumference of the circle is {Math.Round(circumference, 2)}\n" +
                              $"Press enter to exit the program");
            Console.ReadLine();
        }
    }
}