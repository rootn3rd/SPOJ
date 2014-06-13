using System;
using System.Collections.Generic;
using System.Text;

namespace SPOJ
{
    class ACPC10A
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (!input.Equals("0 0 0"))
            {
                string[] inArr = input.Split(' ');
                int[] inputElems = new int[inArr.Length];

                int index = 0;
                foreach (string item in inArr)
                {
                    inputElems[index++] = Int32.Parse(item);
                }

                int a = inputElems[0];
                int d = inputElems[1] - a;

                if (inputElems[2] == a + 2 * d)
                {
                    Console.WriteLine("AP " + (a + 3 * d));
                }
                else
                {
                    int r = inputElems[1] / inputElems[0];

                    if (inputElems[2] == a * r * r)
                    {
                        Console.WriteLine("GP " + (a * Math.Pow(r, 3)));

                    }

                }
                input = Console.ReadLine();
            }


        }
    }
}
