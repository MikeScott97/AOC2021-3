using System;
using System.IO;
using System.Collections.Generic;

namespace AOC2021_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> oxygen = new List<string>(File.ReadAllLines("C:\\Users\\Temp\\Documents\\AOC2021-3.txt"));
            List<string> co2 = new List<string>(oxygen);
            int counter = 0;
            
            do
            {
                //1 means common 0 means uncommon search
                oxygen = diagnosis(oxygen, counter, 1);
                counter++;
            } while (oxygen.Count != 1);

            counter = 0;
            do
            {
                //1 means common 0 means uncommon search
                co2 = diagnosis(co2, counter, 0);
                counter++;
            } while (co2.Count != 1);

            Console.WriteLine(oxygen[0]);
            Console.WriteLine(co2[0]);
            Console.WriteLine((Convert.ToInt32(oxygen[0], 2)) * (Convert.ToInt32(co2[0], 2)));
            
            Console.ReadKey();
        }

        static List<string> diagnosis(List<string> values, int position, int choice)
        {
            double counter = 0;
            int digit = 0, common = 0;
            List<string> grouped0s = new List<string>();
            List<string> grouped1s = new List<string>();

            for (int x = 0; x < values.Count; x++)
            {
                digit = int.Parse(values[x].Substring(position, 1));
                counter += digit;
                switch (digit)
                {
                    case 0:
                        grouped0s.Add(values[x]);
                        break;

                    case 1:
                        grouped1s.Add(values[x]);
                        break;
                }

            }

            common = Convert.ToInt32(Math.Round(counter / values.Count, MidpointRounding.AwayFromZero));

            if(choice == 1 && common == 1 || choice == 0 && common == 0)
            {
                return grouped1s;
            }
            else
            {
                return grouped0s;
            }
        }
    }
}
