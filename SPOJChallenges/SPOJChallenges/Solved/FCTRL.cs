using System;
using System.Collections.Generic;
using System.Text;

namespace SPOJ
{
    class FCTRL
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int number = 0;
            int count = 0;
            int k = 1;
            for (int i = 0; i < n; i++)
            {
                number = Int32.Parse(Console.ReadLine());
                count = 0;
                k = 1;
                
                while (number / Math.Pow(5, k) >= 1)
                {
                    count += (int)(number / Math.Pow(5, k));
                    k += 1;
                }
                Console.WriteLine(count);

            }

        }




    }
}
