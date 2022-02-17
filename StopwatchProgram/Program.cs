// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;

namespace StopwatchProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("stopwatch");
            var stopwatch = new Stopwatch();

            Console.WriteLine("press enter to start");
            Console.ReadLine();
            stopwatch.Start();

            Console.WriteLine("press enter to stop");
            Console.ReadLine();
            stopwatch.Stop();

            var elapsed_time = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"{elapsed_time/1000} seconds");
        }
    }
}


