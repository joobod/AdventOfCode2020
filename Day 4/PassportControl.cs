using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class PassportControl
    {
        string[] keyword = {"byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };
        char[] validity;

        public PassportControl()
        {
            validity = "0000000".ToCharArray();
        }

        public char[] getVal()
        {
            return validity;
        }

        public bool checkVadility()
        {
            foreach(char ch in validity)
            {
                if(ch == '0')
                {
                    return false;
                }
            }
            return true;
        }

        public void addString(string input)
        {
            string[] kvp = input.Split(' ');
            foreach(string key in kvp)
            {
                for (int i = 0; i < keyword.Length; i++)
                {
                    if (key.Split(':')[0] == keyword[i])
                    {
                        Console.WriteLine(key.Split(':')[0]);
                        validity[i] = '1';
                        break;
                    }
                }
            }
        }
    }
}
