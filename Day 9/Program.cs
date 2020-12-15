using System;
using System.Collections.Generic;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Johannes\Documents\0\AdventOfCode\day9input.txt");
            List<UInt64> values = new List<UInt64>();
            foreach(string line in lines)
            {
                values.Add(UInt64.Parse(line));
            }

            Preamble preamble = new Preamble();
            int i = 0;
            for(; i < 25; i++)
            {
                preamble.Add(values[i]);
            }

            for(; i < values.Count; i++)
            {
                if(!preamble.ValidPreamble(values[i]))
                {
                    Console.WriteLine("Invalid Preamble: " + values[i]);
                    UInt64 output = preamble.EncWeakness(values[i], values);
                    Console.WriteLine("Encryption weakness: " + output);
                    break;
                }
                preamble.Add(values[i]);
            }

        }
    }
}
