using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class ArrayPairSum
    {
        public static void run()
        {
            Console.WriteLine(ArrayPairSumRunner(new int[] { 1, 4, 3, 2 }));
        }
        public static int ArrayPairSumRunner(int[] nums)
        {
            int sum = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i += 2)
            {
                //adding all odd nos
                sum += nums[i];
            }
            return sum;
        }
    }
}
