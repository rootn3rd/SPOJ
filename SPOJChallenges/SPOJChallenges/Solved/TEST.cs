using System;
using System.Collections.Generic;
using System.Text;

namespace SPOJ
{
    class TEST
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while(!input.Equals("42"))
            {
                Console.WriteLine(input);
                input = Console.ReadLine();

            }
        }
    }
}
