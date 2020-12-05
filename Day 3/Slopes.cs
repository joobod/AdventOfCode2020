using System;
using System.Collections.Generic;

namespace Day3
{
    internal class Slopes
    {
        public void Stage1(List<char[]> charMap, int lengthOfLine, int nrOfLines)
        {
            int x = 0, y = 0;
            int treecount = 0;
            while (y < nrOfLines)
            {
                if (charMap[y++][x] == '#')
                {
                    treecount++;
                }
                x = (x + 3) % lengthOfLine;
            }
            Console.WriteLine(treecount);
        }

        public uint Stage2(List<char[]> charMap, int lengthOfLine, int nrOfLines, int x, int y)
        {
            int currX = 0, currY = 0;
            uint treecount = 0;
            while (currY < nrOfLines)
            {
                if (charMap[currY][currX] == '#')
                {
                    treecount++;
                }
                currY = currY + y;
                currX = (currX + x) % lengthOfLine;
            }
            Console.WriteLine(treecount);
            return treecount;
        }
    }
}