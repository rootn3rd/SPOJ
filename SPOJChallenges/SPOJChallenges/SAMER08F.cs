using System;
using System.Collections.Generic;
using System.Text;

namespace SPOJChallenges
{
    class SAMER08F
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                int count = 0;
                for (int i = n; i > 0; i--)
                {
                    count += i * i;
                }
                Console.WriteLine(count);
                n = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
