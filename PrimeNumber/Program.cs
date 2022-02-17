// See https://aka.ms/new-console-template for more information
using System;
namespace PrimeNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("prime number");
            Console.WriteLine("enter number: ");
            bool isPrime = true;
            int number = Convert.ToInt32(Console.ReadLine());
            int maxLimit = (number / 2) + 1;
            for (int i = 2; i < maxLimit; i++)
            {
                int remainder = number % i;
                if (remainder == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            string result = isPrime ? "a prime" : "not a prime";
            Console.WriteLine($"{number} is {result}");
        }
    }
}
