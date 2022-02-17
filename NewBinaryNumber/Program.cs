// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

using System;

namespace NewBinaryNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("decimal to binary");
            Console.WriteLine("enetr number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Binary binary = new Binary();
            binary.GetBinary(number);
        }
    }
}

