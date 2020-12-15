using System;
using System.Collections.Generic;

namespace Day7
{
    internal class Bag
    {
        public string color;
        private List<KeyValuePair<string, int>> holds = new List<KeyValuePair<string, int>>();

        public Bag(string input)
        {
            color = input.Split(" bags contain")[0];
            if (input.Split("bags contain")[1] != " no other bags.")
            {
                string[] differentBagOfHoldings = input.Split("bags contain")[1].Split(',');
                foreach (string bagOfHolding in differentBagOfHoldings)
                {
                    string[] kv = bagOfHolding.Split(' ');
                    string key = kv[2] + " " + kv[3];
                    holds.Add(new KeyValuePair<string, int>(key, int.Parse(kv[1])));
                }
            }
        }

        public int GetValue(string key)
        {
            foreach (KeyValuePair<string, int> kvp in holds)
            {
                if (kvp.Key == key)
                {
                    return kvp.Value;
                }
            }
            return -1;
        }

        public List<string> GetAllKeys()
        {
            List<string> keys = new List<string>();
            foreach (KeyValuePair<string, int> kvp in holds)
            {
                keys.Add(kvp.Key);
            }
            return keys;
        }

        public override string ToString()
        {
            string output = color + " bag:\n";
            foreach (KeyValuePair<string, int> kvp in holds)
            {
                output = output + kvp.Value + " " + kvp.Key + "\n";
            }
            return output;
        }

        public int getValue(string key)
        {
            foreach (KeyValuePair<string, int> kvp in holds)
            {
                if (kvp.Key == key)
                {
                    return kvp.Value;
                }
            }
            return -1;
        }

        public List<string> WhatBags(Bag bag)
        {
            List<string> bags = new List<string>();
            foreach (KeyValuePair<string, int> kvp in bag.holds)
            {
                for (int i = 0; i < kvp.Value; i++)
                {
                    bags.Add(kvp.Key);
                }
            }
            return bags;
        }
        public Bag GetBag(string bagColor, List<Bag> bags)
        {
            foreach(Bag bag in bags)
            {
                if(bag.color == bagColor)
                {
                    return bag;
                }
            }
            return null;
        }

        public int HowManyBags(List<Bag> bags)
        {
            Console.WriteLine(ToString());
            int output = 0;
            foreach (KeyValuePair<string, int> kvp in holds)
            {
                output += (kvp.Value * GetBag(kvp.Key, bags).HowManyBags(bags)) + kvp.Value;
            }
            if (output == 0)
            {
                return 1;
            }
            else
            {
                return output;
            }

        }
    }
}