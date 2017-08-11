using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class MergeTrees
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

            TreeNode root2 = new TreeNode(6);
            root2.left = new TreeNode(4);
            root2.right = new TreeNode(7);
            TreeNode temp2;
            temp2 = root2.left;
            temp2.left = new TreeNode(3);
            temp2.right = new TreeNode(5);
            temp2 = root2.right;
            temp2.right = new TreeNode(8);

            Console.WriteLine(MergeTreesRunner(root, root2));
        }

        public static TreeNode MergeTreesRunner(TreeNode t1, TreeNode t2)
        {
            if (t1 == null || t2 == null)
            {
                if(t1 == null)
                {
                    return t2;
                }
                else
                {
                    return t1;
                }
            }
            else
            {
                t1.val = t1.val + t2.val;
                t1.left = MergeTreesRunner(t1.left, t2.left);
                t1.right = MergeTreesRunner(t1.right, t2.right);
            }
            return t1;
        }
    }
}
