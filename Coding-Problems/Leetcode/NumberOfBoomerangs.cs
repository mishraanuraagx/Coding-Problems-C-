using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class NumberOfBoomerangs
    {
        public static void run()
        {
            int[,] listOfPointsOnPlane = new int[3, 2] {
                { 0, 0},{ 1, 0},{ 2, 0}
        };
            NumberOfBoomerangs.NumberOfBoomerangsRunner(listOfPointsOnPlane);



        }

        public static int NumberOfBoomerangsRunner(int[,] points)
        {
            int numberOfPoints = points.GetLength(0);
            /*
             * for rectangular matrix, each n rows contains m items
             */
            int numOfAxises = points.Length / numberOfPoints;
            Console.WriteLine(numberOfPoints);
            Console.WriteLine(numOfAxises);

            return 2;
        }
    }
}
