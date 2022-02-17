// See https://aka.ms/new-console-template for more information
using System;
namespace tempConverter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("temperature conversion");
            Console.WriteLine("enter 1: Celsius to Fahrenheit    2: Fahrenheit to Celsius");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter temperature");
            int temp = Convert.ToInt32(Console.ReadLine());

            GetTemp(option, temp);
        }
        public static void GetTemp(int option, int temp)
        {

            switch (option)
            {
                case 1:
                    int F = (temp * 9 / 5) + 32;
                    Console.WriteLine($"{F} fahrenheit");
                    break;
                case 2:
                    int C = (temp - 32) * 5 / 9;
                    Console.WriteLine($"{C} celsius");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
    }
}
