using System;
using System.Collections.Generic;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardingPass bp;
            string[] boardingPasses = System.IO.File.ReadAllLines(@"C:\Users\Johannes\Documents\0\AdventOfCode\day5input.txt");

            int maxSeat = 0;
            List<int> seatList = new List<int>();
            foreach(string boardingpass in boardingPasses)
            {
                bp = new BoardingPass(boardingpass);
                bp.getRow();
                bp.getCol();
                bp.setSeat();
                seatList.Add(bp.getSeat());
            }
            seatList.Sort();
            int shouldbeid = 49;
            for (int i = 1; i < seatList.Count - 1; i++, shouldbeid++)
            {
                if(seatList[i-1] != shouldbeid-1)
                {
                    Console.WriteLine(shouldbeid-1);
                    break;
                }
            }
        }
    }
}
