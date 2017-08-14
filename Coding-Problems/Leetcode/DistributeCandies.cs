using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Coding_Problems.Leetcode
{
    class DistributeCandies
    {
        public static void run()
        {
            Console.WriteLine(DistributeCandiesRunner(new int[] { 1, 1, 2, 3 }));
            Console.WriteLine(DistributeCandiesRunner(new int[] { 1, 1, 2, 2, 3, 3 }));

        }

        public static int DistributeCandiesRunner(int[] candies)
        {
            Dictionary<int, int> candiesCount = new Dictionary<int, int>();
            for (int i = 0; i < candies.Length; i++)
            {
                int count;
                if (!candiesCount.TryGetValue(candies[i], out count))
                {
                    candiesCount.Add(candies[i],1);

                }
                else
                {
                    candiesCount[candies[i]] = count + 1;
                }

            }

            int uniqueCandiesForSister = candiesCount.Count > candies.Length / 2 ? candies.Length/2 : candiesCount.Count;
            return uniqueCandiesForSister;
        }
    }
}
