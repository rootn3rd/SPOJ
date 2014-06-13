using System;
using System.Collections.Generic;
using System.Text;

namespace SPOJ
{
    class AMR11E
    {

        static List<int> Lucky = new List<int>();
        //static Dictionary<int, List<int>> LuckyDict = new Dictionary<int, List<int>>();

        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());

            GeneratePrimes();
            Lucky.Sort();
            int required = 0;
            for (int index = 0; index < number; index++)
            {
                required = Int32.Parse(Console.ReadLine());
                if (required < 1001)
                    Console.WriteLine(Lucky[required - 1]);
            }
        }

        public static void GeneratePrimes()
        {
          
            int index = 0;
            int seed = 30;
           // LuckyDict.Add(30, new List<int> { 2, 3, 5 });
            Lucky.Add(seed++);
            index++;

            List<int> factors = new List<int>();
            while (Lucky.Count != 1000)
            {

                for (int i = 2; i < seed / 2; i++)
                {
                    if (seed % i == 0)
                    {
                        if (!factors.Contains(i))
                            factors.Add(i);

                        int ans = seed / i;
                        if (!factors.Contains(ans))
                            factors.Add(ans);
                    }
                }
                int factorCount = 0;
                foreach (int item in factors)
                {
                    if (IsPrime(item))
                        factorCount++;
                }

                if (factorCount >= 3)
                {
                    Lucky.Add(seed);

                    //int result = 1;
                    //factors.ForEach(x => result *= x);
                    //if (!Lucky.Contains(result))
                    //{
                    //    Lucky.Add(result);
                    //   // LuckyDict.Add(result, new List<int>(factors));
                    
                    //}
                }

                factors.Clear();
                seed++;
            }

          

        }

        public static bool IsPrime(int number)
        {
            if (number == 1)
                return true;
            if (number < 4)
                return true;
            if (number % 2 == 0)
                return false;
            if (number < 9)
                return true;
            if (number % 3 == 0)
                return false;
            else
            {
                double root = Math.Floor(Math.Sqrt(number));
                int factor = 5;
                while (factor <= root)
                {
                    if (number % factor == 0)
                        return false;
                    if (number % (factor + 2) == 0)
                        return false;

                    factor += 6;
                }
            }

            return true;

        }
    }
}
