using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Day2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch stopWatch1 = new Stopwatch();

            d2 d2 = new d2();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Johannes\Documents\0\AdventOfCode\day2input.txt");
            List<PW> pws = new List<PW>();

            stopWatch1.Start();

            foreach (string line in lines)
            {
                pws.Add(new PW(line));
            }
            int count = 0;
            foreach (PW pw in pws)
            {
                if (pw.validPW)
                {
                    count++;
                }
            }
            stopWatch1.Stop();
            TimeSpan ts1 = stopWatch1.Elapsed;
            Console.WriteLine(ts1.TotalMilliseconds + " ms");

            Console.WriteLine(count);
        }
    }
}