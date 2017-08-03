using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class SearchMatrix
    {
        public static void run()
        {
            int[,] matrix = new int[,] {
                { 1,   3,  5,  7},{10, 11, 16, 20},{ 23, 30, 34, 50}
        };
            int target = 16;

            Console.WriteLine(SearchMatrix.SearchMatrixRunner(matrix, target));


        }

        public static bool SearchMatrixRunner(int[,] matrix, int target)
        {
            bool found = false;
            int startIndex = 0;
            int endIndex = matrix.Length - 1;
            int center = (endIndex - startIndex) / 2;

            while (startIndex != endIndex)
            {

                int rowOfTheCenterItem = center / matrix.GetLength(0);
                int columnOfTheCenterItem = center % matrix.GetLength(1);

                Console.WriteLine(center);
                Console.WriteLine(rowOfTheCenterItem + ":" + columnOfTheCenterItem);

                if (matrix[rowOfTheCenterItem, columnOfTheCenterItem] == target)
                {
                    return true;
                }
                else if (matrix[rowOfTheCenterItem, columnOfTheCenterItem] > target)
                {
                    endIndex = center;

                    center -= (endIndex - startIndex) / 2;
                }
                else
                {
                    startIndex = center;
                    center += (endIndex - startIndex) / 2;
                }
                Console.WriteLine(startIndex + ":" + endIndex);
            }



            return found;
        }
    }
}
