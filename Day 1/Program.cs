using System;

using System.Diagnostics;
using System.Threading;

namespace Day1
{
    class Program
    {
        static public void Main(String[] args)
        {
            Day day = new Day();
            Stopwatch stopWatch1 = new Stopwatch();
            Stopwatch stopWatch2 = new Stopwatch();
            int[] input = day.parseStringArrayToIntArray(day.readInput(@"C:\Users\Johannes\Documents\0\input.txt"));
            int output;
            stopWatch1.Start();
            output = day.printResultsPart1(input);
            stopWatch1.Stop();
            stopWatch2.Start();
            output = day.printResultsPart2(input);
            stopWatch2.Stop();
            Console.WriteLine(output);
            TimeSpan ts1 = stopWatch1.Elapsed;
            TimeSpan ts2 = stopWatch2.Elapsed;


            // Format and display the TimeSpan value.
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            //Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine(ts1.TotalMilliseconds + " ms");
            Console.WriteLine(ts2.TotalMilliseconds + " ms");

        }
    }
}