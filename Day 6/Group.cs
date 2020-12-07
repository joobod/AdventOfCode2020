using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Group
    {
        HashSet<char> set = new HashSet<char>();
        List<char> charsToRemove = new List<char>();
        public void AddLine2(string line)
        {
            Console.WriteLine(line);
            if (set.Count == 0)
            {
                foreach (char ch in line)
                {
                    set.Add(ch);
                }
            }
            else
            {
                foreach (char ch in set)
                {
                    if (!line.Contains(ch))
                    {
                        charsToRemove.Add(ch);
                    }
                }
                foreach(char ch in charsToRemove)
                {
                    set.Remove(ch);
                }
                charsToRemove.Clear();
            }
        }
        public void AddLine(string line)
        {
            foreach(char ch in line.ToCharArray())
            {
                set.Add(ch);
            }
        }
        
        public char[] getResults()
        {
            char[] res = new char[set.Count];
            int i = 0;
            foreach(char ch in set)
            {
                res[i++] = ch;
            }
            return res;

        }

        public int getSum()
        {
            return set.Count;
        }


        
    }
}
