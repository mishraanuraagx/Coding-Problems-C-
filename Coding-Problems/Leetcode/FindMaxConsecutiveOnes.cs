using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class FindMaxConsecutiveOnes
    {
        public static void run()
        {
            Console.WriteLine(FindMaxConsecutiveOnesRunner(new int[] { 1, 1, 0, 1, 1, 1 }));
        }

        public static int FindMaxConsecutiveOnesRunner(int[] nums)
        {
            int counter = 0, maxCountedValue = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if((nums[i] & 1) == 1 )
                {
                    counter++;
                }
                else
                {
                    maxCountedValue = Math.Max(maxCountedValue, counter);
                    counter = 0;
                }

            }
            return Math.Max(maxCountedValue,counter);
        }
    }
}
