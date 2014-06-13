using System;
using System.Collections.Generic;
using System.Text;

namespace SPOJ
{
    class FASHION
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                int leng = Int32.Parse(Console.ReadLine());
                string menStr = Console.ReadLine();
                string[] menStrArry = menStr.Split(' ');

                int[] men = new int[menStrArry.Length];
                int index=0;
                foreach (string item in menStrArry)
                {
                    men[index++] = Int32.Parse(item);
                }

                Array.Sort(men);

                string womenStr = Console.ReadLine();
                string[] womenStrArry = womenStr.Split(' ');

                int[] women = new int[womenStrArry.Length];
                index = 0;
                foreach (string item in womenStrArry)
                {
                    women[index++] = Int32.Parse(item);
                }

                Array.Sort(women);

                int sum = 0;
                for (int j = 0; j < leng; j++)
                {
                    sum += men[j] * women[j];
                }
                Console.WriteLine(sum);

            }
        }

    }
}
