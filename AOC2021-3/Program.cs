using System;
using System.IO;
using System.Collections.Generic;

namespace AOC2021_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("C:\\Users\\Temp\\Documents\\AOC2021-3.txt");
            string gamma = "", epsilon = "";
            double counter;
            int numG, numE;

            for (int i = 0; i < inputs[0].Length; i++)
            {
                counter = 0;

                for (int x = 0; x < inputs.Length; x++)
                {
                    counter += double.Parse(inputs[x].Substring(i, 1));
                }

                if (counter / inputs.Length > 0.5)
                {
                    gamma += "1";
                    epsilon += "0";
                }
                else
                {
                    gamma += "0";
                    epsilon += "1";
                }

            }

            numG = Convert.ToInt32(gamma, 2);
            numE = Convert.ToInt32(epsilon, 2);

            Console.WriteLine(gamma);
            Console.WriteLine(numG);
            Console.WriteLine(epsilon);
            Console.WriteLine(numE);
            Console.ReadKey();
        }
    }
}
