using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class FindDisappearedNumbers
    {
        public static void run()
        {
            Console.WriteLine(String.Join(",", FindDisappearedNumbersRunner(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 })));
        }

        public static IList<int> FindDisappearedNumbersRunner(int[] nums)
        {
            IList<int> missingNumberList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i]) - 1] > 0)
                {
                    nums[Math.Abs(nums[i]) - 1] *= -1;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    missingNumberList.Add(i + 1);
                }
            }
            return missingNumberList;
        }
    }
}
