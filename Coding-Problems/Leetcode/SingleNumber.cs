using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
//TODO max: writing efficent code is difficult and wrong answer, input has negative nos, input array with one integer, so go figure
{
    class SingleNumber
    {
        public static void run()
        {
            Console.WriteLine(SingleNumberRunner(new int[] { 1, 6, 2, 2, 7, 3, 7, 6, 1, 0, 3, 4, 4, 5, 5, 22, 22 }));
        }

        public static int SingleNumberRunner(int[] nums)
        {
            int[] bigArray = new int[Math.Max(nums.Length, nums.Max()) + 1];
            Array.Copy(nums, bigArray, nums.Length);
            int valueSet = int.MaxValue;

            for (int i = nums.Length; i < bigArray.Length; i++)
            {
                bigArray[i] = valueSet;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                bigArray[Math.Abs(bigArray[i])] *= -1;
            }
            return Array.IndexOf(bigArray, bigArray.Min());
        }
    }
}
