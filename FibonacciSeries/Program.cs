// See https://aka.ms/new-console-template for more information
using System;
namespace FibonacciSeries
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Series");
            Console.WriteLine("enter number:");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Fibonacci = 0;
            int Previous2 = 1;
            for (int i = 0; i < Number; i++)
            {
                int Previous1 = Previous2;
                Previous2 = Fibonacci;
                Fibonacci += Previous1;
                Console.WriteLine(Fibonacci);
            }
        }
    }
}
