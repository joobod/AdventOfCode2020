using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    class Day
    {
        public string[] readInput(string filepath)
        {
            return System.IO.File.ReadAllLines(filepath);
        }
        public int[] parseStringArrayToIntArray(string[] lines)
        {
            int[] inputs = new int[lines.Length];
            int i = 0;
            foreach (string line in lines)
            {
                inputs[i++] = int.Parse(line);
            }
            return inputs;
        }
        public int printResultsPart1(int[] inputs)
        {
            for (int x = 0; x < inputs.Length; x++)
            {
                for (int y = 0; y < inputs.Length; y++)
                {
                    //Console.WriteLine(inputs[x] + " " + inputs[y]);
                    if (inputs[x] + inputs[y] == 2020)
                    {
                        //Console.WriteLine("X: " + inputs[x] + " Y: " + inputs[y] + " X*Y= " + inputs[x] * inputs[y]);
                        return inputs[x] * inputs[y];
                    }
                }
            }
            return -1;
        }

        public int printResultsPart2(int[] inputs)
        {
            for (int z = 0; z < inputs.Length; z++)
            {
                for (int x = 0; x < inputs.Length; x++)
                {
                    for (int y = 0; y < inputs.Length; y++)
                    {
                        //Console.WriteLine(inputs[x] + " " + inputs[y]);
                        if (inputs[x] + inputs[y] + inputs[z] == 2020)
                        {
                            //Console.WriteLine("X: " + inputs[x] + " Y: " + inputs[y] + " X*Y= " + inputs[x] * inputs[y]);
                            return inputs[x] * inputs[y] * inputs[z];
                        }
                    }
                }
            }
            return -1;
        }
    }
}
