using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    class Preamble
    {
        List<UInt64> preamble = new List<UInt64>();
        const int size = 25;
        int currentSize = 0;
        public void Add(UInt64 addThis)
        {
            if(currentSize == size)
            {
                preamble.RemoveAt(0);
                currentSize--;
            }
            preamble.Add(addThis);
            currentSize++;
        }

        public bool ValidPreamble(UInt64 target)
        {
            for(int i = 0; i < size; i++)
            {
                if (preamble[i] < target)
                {
                    for (int j = size - 1; j > i; j--)
                    {
                        if (preamble[j] < target)
                        {
                            if (preamble[j] + preamble[i] == target)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public UInt64 EncWeakness(UInt64 target, List<UInt64> listOfValues)
        {
            List<UInt64> rangeOfValues = new List<UInt64>();
            UInt64 tot = 0;
            for (int i = 0; i < listOfValues.Count; i++)
            {
                rangeOfValues.Add(listOfValues[i]);
                for (int j = i+1; j < listOfValues.Count; j++)
                {
                    rangeOfValues.Add(listOfValues[j]);
                    tot = GetSumOfList(target, rangeOfValues);
                    if (tot == target)
                    {
                        UInt64 max = 0;
                        UInt64 min = UInt64.MaxValue;
                        foreach(UInt64 value in rangeOfValues)
                        {
                            if(value < min)
                            {
                                min = value;
                            }
                            if( value > max)
                            {
                                max = value;
                            }
                            Console.WriteLine(value);
                        }
                        return min + max;
                        
                    }
                    else if(tot > target)
                    {
                        break;
                    }
                }
                rangeOfValues.Clear();
            }
            return 0;
        }
        private UInt64 GetSumOfList(UInt64 target, List<UInt64> list)
        {
            UInt64 tot = 0;
            foreach (UInt64 value in list)
            {
                tot += value;
            }
            return tot;
        }
    }
}
