using System;
using System.Collections.Generic;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = System.IO.File.ReadAllLines(@"C:\Users\Johannes\Documents\0\AdventOfCode\day7input.txt");
            List<Bag> bags = new List<Bag>();
            foreach(string eachBag in input)
            {
                bags.Add(new Bag(eachBag));
            }

            List<string> bagsThatCanHoldShinyBag = new List<string>();
            List<string> AddToThisList = new List<string>();
            List<string> CheckThisList = new List<string>();

            CheckThisList.Add("shiny gold");
            bool changed = true;
            while (changed)
            {
                changed = false;
                foreach (Bag bag in bags)
                {
                    foreach (string key in bag.GetAllKeys())
                    {
                        if (CheckThisList.Contains(key))
                        {
                            AddToThisList.Add(bag.color);
                            changed = true;
                            break;
                        }
                    }
                }
                foreach(string str in CheckThisList)
                {
                    bagsThatCanHoldShinyBag.Add(str);
                }
                CheckThisList.Clear();
                foreach(string str in AddToThisList)
                {
                    CheckThisList.Add(str);
                }
                AddToThisList.Clear();
            }

            int shinyBag = -1; // Because shinybag

            foreach (Bag bag in bags)
            {
                if(bagsThatCanHoldShinyBag.Contains(bag.color))
                {
                    shinyBag++;
                }
            }
            Console.WriteLine(shinyBag);


            foreach(Bag bag in bags)
            {
                if(bag.color == "shiny gold")
                {
                    Console.WriteLine(bag.HowManyBags(bags));
                }
            }
        }
    }
}
