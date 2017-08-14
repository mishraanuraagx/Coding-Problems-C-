using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class InvertTree
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
            root = InvertTreeRunner(root);

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count != 0)
            {
                temp = q.Dequeue();
                if (temp.left != null)
                {
                    q.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    q.Enqueue(temp.right);
                }
                Console.WriteLine(temp.val);
            }
        }

        public static TreeNode InvertTreeRunner(TreeNode root)
        {
            if (root == null) return null;
            TreeNode temp = new TreeNode(root.val);
            temp.left = InvertTreeRunner(root.right);
            temp.right = InvertTreeRunner(root.left);
            return temp;
        }
    }
}
