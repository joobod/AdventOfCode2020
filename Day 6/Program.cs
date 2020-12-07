using System;
using System.Collections.Generic;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] allLines = System.IO.File.ReadAllLines(@"C:\Users\Johannes\Documents\0\AdventOfCode\day6input.txt");
            List<Group> allGroups = new List<Group>();

            Group gp = new Group();
            for (int i = 0; i < allLines.Length; i++)
            {
                gp.AddLine2(allLines[i]);
                if (i + 1 == allLines.Length || allLines[i + 1] == "")
                {
                    allGroups.Add(gp);
                    gp = new Group();
                    i++;
                }
            }

            int totsum = 0;
            foreach (Group group in allGroups)
            {
                totsum += group.getSum();
                Console.WriteLine(group.getSum());
            }
            Console.WriteLine(totsum);

        }
    }
}
