using System;
using System.Collections.Generic;
using System.Text;

namespace SPOJ
{
    class TOANDFRO
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(5 % 3);

            string input = Console.ReadLine();
            char[] inArr = null;
            int columnsize = 0;
            while (!input.Equals("0"))
            {
                columnsize = Int32.Parse(input);
                input = Console.ReadLine();

                inArr = input.ToCharArray();
                int length = inArr.Length;

                int numrows = (int)length / columnsize;

                int index = columnsize;
                while (index < length)
                {
                    Array.Reverse(inArr, index, columnsize);
                    index += columnsize*2;
                }

                char[] result = new char[length];
                int startInd = 0;
                index = 0;
                while (startInd < columnsize)
                {
                    for (int i = startInd; i < length; i += columnsize)
                    {
                        result[index++] = inArr[i];
                    }
                    startInd += 1;
                }
                Console.WriteLine(new string(result));
                input = Console.ReadLine();
            }
            
        }
    }
}
