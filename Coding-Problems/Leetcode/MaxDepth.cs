using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class MaxDepth
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
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(3);
            root.right = new TreeNode(6);
            TreeNode temp;
            temp = root.left;
            temp.left = new TreeNode(2);
            temp.right = new TreeNode(4);
            temp = root.right;
            temp.right = new TreeNode(7);
            Console.WriteLine(MaxDepthRunner(root));
        }

        public static int MaxDepthRunner(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Max(MaxDepthRunner(root.left), MaxDepthRunner(root.right)) + 1;
        }
    }
}
