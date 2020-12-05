using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines =  System.IO.File.ReadAllLines(@"C:\Users\Johannes\Documents\0\AdventOfCode\day4input.txt");
            PassportControl pc = new PassportControl();
            int passportStartIndex = 0;
            int amount = 0, totAmount = 0;
            for(int i = 0; i < lines.Length; i++)
            {
                if(lines[i] == "")
                {
                    Console.WriteLine("\nNew Passport:\n");
                    //Passport is passportStartIndex -> i
                    for(int j = passportStartIndex; j < i; j++ )
                    {
                        pc.addString(lines[j]);
                        Console.WriteLine(lines[j]);
                    }
                    totAmount++;
                    //Set passportStartIndex = i+1
                    Console.WriteLine("Passport checked!");
                    Console.WriteLine(pc.getVal());
                    if (pc.checkVadility())
                    {
                        Console.WriteLine("Passport valid!");
                        amount++;
                    }
                    else
                    {
                        Console.WriteLine("Passport invalid!");
                    }
                    passportStartIndex = i + 1;
                    pc = new PassportControl();
                }
            }
            Console.WriteLine(amount + "/" + totAmount);

        }
    }
}
