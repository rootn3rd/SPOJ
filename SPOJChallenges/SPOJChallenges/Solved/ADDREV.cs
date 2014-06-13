using System;
using System.Collections.Generic;
using System.Text;

namespace SPOJ
{
    class ADDREV
    {
        static void Main(string[] args)
        {
            //test code
            //while (true)
            //{
            //    string num1 = GetReverse(Console.ReadLine());
            //    string num2 = GetReverse(Console.ReadLine());

            //    Console.WriteLine(GetReverse(GetSum(num1, num2)));

            //}


            int times = Int32.Parse(Console.ReadLine());

            string input = string.Empty;
            string num1 = string.Empty;
            string num2 = string.Empty;
            for (int i = 0; i < times; i++)
            {
                input = Console.ReadLine();
                num1 = GetReverse(input.Split(' ')[0]);
                num2 = GetReverse(input.Split(' ')[1]);

                Console.WriteLine(GetReverse(GetSum(num1, num2)));
            }
        }

        static string GetSum(string num1, string num2)
        {
            string final = string.Empty;
            int difference = 0;
            string appender = string.Empty;

            //finding the bigger number
            if (num1.Length < num2.Length)
            {
                //append difference to num1
                difference = num2.Length - num1.Length;

                for (int i = 0; i < difference; i++)
                {
                    appender += "0";
                }
                num1 = appender + num1;
            }
            else if (num1.Length > num2.Length)
            {
                //append difference to num2
                difference = num1.Length - num2.Length;

                for (int i = 0; i < difference; i++)
                {
                    appender += "0";
                }
                num2 = appender + num2;
            }



            int carry = 0;
            int sum = 0;
            for (int i = (num1.Length) - 1; i >= 0; i--)
            {
                sum = Int32.Parse(num1[i].ToString()) + Int32.Parse(num2[i].ToString()) + carry;

                if (sum > 9)
                {
                    carry = 1;
                    sum = sum - 10;
                }
                else
                {
                    carry = 0;
                }

                final += sum;
            }

            final += carry;

            //reversing final
            char[] result = final.ToCharArray();
            final = string.Empty;

            for (int i = result.Length - 1; i >= 0; i--)
            {
                final += result[i];
            }
           
            final = final.TrimStart('0');

            return final;
        }

        static string GetReverse(string number)
        {
            char[] original = number.ToCharArray();
            string final = string.Empty;

            for (int i = original.Length - 1; i >= 0; i--)
            {
                final += original[i];
            }
            final = final.TrimStart('0');

            //Console.WriteLine(final);
            //Console.WriteLine(Int32.Parse(final));

            return final;
        }
    }
}
