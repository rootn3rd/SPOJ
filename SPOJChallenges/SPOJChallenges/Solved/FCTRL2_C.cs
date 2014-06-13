using System;
using System.Collections.Generic;
using System.Text;

/**
 * Program to multiply large numbers
 * **/

namespace SPOJ
{
    class FCTRL2_C
    {
        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());

            while (t != 0)
            {
                int num;
                int i, k = 0, j, carry = 0;
                int[] arr = new int[1000];
                arr[0] = 1;
                num = Int32.Parse(Console.ReadLine());

                for (i = 1; i <= num; i++)
                {
                    for (j = 0; j <= k; j++)
                    {
                        arr[j] = arr[j] * i + carry;
                        carry = arr[j] / 10;
                        arr[j] = arr[j] % 10;
                    }
                    while (carry>0)
                    {
                        k++;
                        arr[k] = carry % 10;
                        carry /= 10;
                    }
                }

                for (i = k; i >= 0; i--)
                    Console.Write(arr[i]);
                Console.WriteLine();
                t--;
            }
        }

    }
}
