using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class MatrixReshape
    {
        public static void run()
        {
            int r = 1, c = 4;
            int[,] nums = { { 1, 2 }, { 3, 4 } };
            int[,] nums2 = { { 1, 2, 3, 4 } };

            int[,] result = MatrixReshapeRunner(nums, r, c);
            //int[,] result = MatrixReshapeRunner(nums2, 2, 2);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + ",");
                }
                Console.WriteLine();
            }

        }

        public static int[,] MatrixReshapeRunner(int[,] nums, int r, int c)
        {
            int[,] result = new int[r, c];

            if (nums.GetLength(0) * nums.GetLength(1) != r * c)
            {
                return nums;
            }
            Console.WriteLine(nums.GetLength(1));
            for (int i = 0; i < r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    int index = i*c + j;
                    int isLastDigitOfTheRow = 0;
                    if (index % nums.GetLength(1) == 0)
                    {
                        /*
                         * if true then fix the row and col
                         */
                        isLastDigitOfTheRow = 1;
                    }
                    int rowOfNums = index / nums.GetLength(1) - (isLastDigitOfTheRow);
                    int columnOfNums = index % nums.GetLength(1) + (isLastDigitOfTheRow * (nums.GetLength(1)));
                    Console.WriteLine(rowOfNums + ":" + (columnOfNums-1));
                    result[i , j - 1] = nums[rowOfNums, columnOfNums - 1];
                }
            }

            return result;
        }
    }
}
