using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO max: in-progress
namespace Coding_Problems.Leetcode
{
    class LeetCodeWeeklyContest45_2017
    {
        public static void run()
        {
            LeetCodeWeeklyContest45_2017 lcwc = new LeetCodeWeeklyContest45_2017();
            Console.WriteLine(lcwc.JudgeCircle("lRUD"));

            Console.WriteLine(string.Join(",", lcwc.FindClosestElements(new List<int>(new int[] { 1, 2, 3, 4, 5 }), 4, 3)));
        }

        public bool JudgeCircle(string moves)
        {
            Dictionary<char, int> numberOfMovesInADirection = new Dictionary<char, int>();
            foreach (char move in moves.ToLower())
            {
                int count;
                numberOfMovesInADirection.TryGetValue(move, out count);
                numberOfMovesInADirection[move] = count + 1;
            }
            int leftCount, rightCount, upCount, downCount;
            numberOfMovesInADirection.TryGetValue('l', out leftCount);
            numberOfMovesInADirection.TryGetValue('r', out rightCount);
            numberOfMovesInADirection.TryGetValue('u', out upCount);
            numberOfMovesInADirection.TryGetValue('d', out downCount);
            return ((leftCount == rightCount && upCount == downCount) ? true : false);
        }

        public IList<int> FindClosestElements(IList<int> arr, int k, int x)
        {
            IList<int> listOfClosestnumbers = new List<int>();
            int[] arrayList = arr.ToArray();
            int startIndex = 0;
            int endIndex = arrayList.Length - 1;
            int midIndex = (endIndex - startIndex) / 2;
            while (arrayList[midIndex] != x && endIndex >= startIndex)
            {
                if (arrayList[midIndex] > x)
                {
                    endIndex = midIndex;
                }
                else
                {
                    startIndex = midIndex;
                }

                midIndex = (endIndex - startIndex) / 2;

            }

            int leftCount = midIndex - 1;
            int rightCount = midIndex + 1;
            for (int i = 0; i < k; i++)
            {
                if (arrayList[midIndex] - arrayList[leftCount] < arrayList[rightCount] - arrayList[midIndex])
                {
                    listOfClosestnumbers.Add(arrayList[leftCount]);
                    leftCount--;
                }
                else
                {
                    listOfClosestnumbers.Add(arrayList[rightCount]);
                    rightCount++;
                }
            }
            return listOfClosestnumbers;
        }
    }
}
