using System;
using System.Collections.Generic;

namespace Day3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 0, y = 0;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Johannes\Documents\0\AdventOfCode\day3input.txt");
            int lengthOfLine = lines[0].Length;
            List<char[]> charMap = new List<char[]>();
            for (int i = 0; i < lines.Length; i++)
            {
                charMap.Add(lines[i].ToCharArray());
            }

            Slopes sl = new Slopes();
            sl.Stage1(charMap, lengthOfLine, lines.Length);

            uint stage2 = 1;

            stage2 *= sl.Stage2(charMap, lengthOfLine, lines.Length, 1, 1);
            stage2 *= sl.Stage2(charMap, lengthOfLine, lines.Length, 3, 1);
            stage2 *= sl.Stage2(charMap, lengthOfLine, lines.Length, 5, 1);
            stage2 *= sl.Stage2(charMap, lengthOfLine, lines.Length, 7, 1);
            stage2 *= sl.Stage2(charMap, lengthOfLine, lines.Length, 1, 2);

            Console.WriteLine("Tot: " + stage2);
        }
    }
}