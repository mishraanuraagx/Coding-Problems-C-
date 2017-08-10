using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO max fix/rewrite this, working very wrong
//It is working, first time "I rewrite code and it worked" on first go, you got guts bro

/*Given an integer array with no duplicates. A maximum tree building on this array is defined as follow: 
1.The root is the maximum number in the array. 
2.The left subtree is the maximum tree constructed from left part subarray divided by the maximum number.
3.The right subtree is the maximum tree constructed from right part subarray divided by the maximum number.


Construct the maximum tree by the given array and output the root node of this tree. 
*/

namespace Coding_Problems.Leetcode
{
    class ConstructMaximumBinaryTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public static void run()
        {
            Console.WriteLine(ConstructMaximumBinaryTreeRunner(new int[] { 3, 2, 1, 6, 0, 5 }));
        }

        public static TreeNode ConstructMaximumBinaryTreeRunner(int[] nums)
        {
            int maxValue = nums.Max();
            int indexOfMaxValue = Array.IndexOf(nums, maxValue);
            TreeNode root = new TreeNode(maxValue);
            Console.WriteLine(maxValue + ":" + indexOfMaxValue);

            if (indexOfMaxValue == 0)
            {
                root.left = null;
            }
            else
            {
                int[] subArrayLeft = new int[indexOfMaxValue];
                Array.Copy(nums, 0, subArrayLeft, 0, indexOfMaxValue);
                root.left = ConstructMaximumBinaryTreeRunner(subArrayLeft);
            }
            if (indexOfMaxValue == nums.Length - 1)
            {
                root.right = null;
            }
            else
            {
                int[] subArrayRight = new int[nums.Length - indexOfMaxValue - 1];
                Array.Copy(nums, indexOfMaxValue + 1, subArrayRight, 0, nums.Length - indexOfMaxValue - 1);
                root.right = ConstructMaximumBinaryTreeRunner(subArrayRight);
            }
            return root;
        }



    }
}
