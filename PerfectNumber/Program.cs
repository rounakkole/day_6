﻿// See https://aka.ms/new-console-template for more information
using System;
namespace PerfectNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("perfect number");
            Console.WriteLine("enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int maxLimit = (number / 2) + 1;
            int sum = 0;
            for (int i = 1; i < maxLimit; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            string result = number == sum ? "a" : "not a";
            Console.WriteLine($"{number} is {result} perfect number");

        }
    }
}
