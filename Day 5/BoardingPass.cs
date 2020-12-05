using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class BoardingPass
    {
        char[] first7;
        char[] last3;
        int row;
        int col;
        int seat;

        public BoardingPass(string boardingpass)
        {
            first7 = boardingpass.Substring(0, 7).ToCharArray();
            last3 = boardingpass.Substring(7, 3).ToCharArray();
        }

        public int getSeat()
        {
            return seat;
        }

        public int getRow()
        {
            int botRow = 0, topRow = 127;

            for(int i = 0; i < 7; i++)
            {
                if(first7[i] == 'F')
                {
                    topRow -= (int) Math.Ceiling((double)((topRow-botRow) / 2.0));
                }
                else
                {
                    botRow += (int) Math.Ceiling((double)((topRow-botRow) / 2.0));
                }
            }
            row = botRow;
            return row;
        }

        public int getCol()
        {
            int leftCol = 0, rightCol = 7;

            foreach(char ch in last3)
            {
                if (ch == 'L')
                {
                    rightCol -= (int)Math.Ceiling((double)((rightCol - leftCol) / 2.0));
                }
                else
                {
                    leftCol += (int)Math.Ceiling((double)((rightCol - leftCol) / 2.0));
                }
            }
            col = leftCol;
            return col;
        }
        public void setSeat()
        {
            seat = (row * 8) + col;
        }
}
}
