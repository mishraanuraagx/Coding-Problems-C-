using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class NextGreaterElement
    {
        public static void run()
        {
            Console.WriteLine(String.Join(",", NextGreaterElementRunner(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 })));
        }

        public static int[] NextGreaterElementRunner(int[] findNums, int[] nums)
        {
            Dictionary<int, int> numWithIndex = new Dictionary<int, int>();
            //Dictionary<int, int> indexWithNum = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                numWithIndex.Add(nums[i], i);
                //indexWithNum.Add(i, nums[i]);
            }

            int[] NextGreatElementArray = new int[findNums.Length];

            for (int i = 0; i < findNums.Length; i++)
            {
                int indexOfNum = numWithIndex[findNums[i]];
                indexOfNum++;
                if (indexOfNum < nums.Length)
                {
                    bool foundGreater = false;
                    int value = -1;
                    for (int j = indexOfNum; j < nums.Length; j++)
                    {
                        if (nums[j] > findNums[i])
                        {
                            foundGreater = true;
                            value = nums[j];
                            break;
                        }
                    }

                    NextGreatElementArray[i] = value;
                }
                else
                {
                    NextGreatElementArray[i] = -1;
                }

            }

            return NextGreatElementArray;
        }
    }
}
