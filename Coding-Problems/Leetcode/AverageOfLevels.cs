using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class AverageOfLevels
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

            Console.WriteLine(String.Join(",", AverageOfLevelsRunner(root)));
        }

        public static IList<double> AverageOfLevelsRunner(TreeNode root)
        {
            IList<double> avgOfLevels = new List<double>();
            Queue<TreeNode> allParentNodesAtSameLevel = new Queue<TreeNode>();
            allParentNodesAtSameLevel.Enqueue(root);
            while (allParentNodesAtSameLevel.Count > 0)
            {
                Queue<TreeNode> childNodesAtSameLevel = new Queue<TreeNode>();
                double sum = 0;
                double i;
                int numOfNodes = allParentNodesAtSameLevel.Count;
                for (i = 0; i < numOfNodes; i++)
                {
                    TreeNode temp = allParentNodesAtSameLevel.Dequeue();
                    sum += temp.val;
                    if (temp.left != null)
                    {
                        childNodesAtSameLevel.Enqueue(temp.left);
                    }
                    if (temp.right != null)
                    {
                        childNodesAtSameLevel.Enqueue(temp.right);
                    }
                }
                avgOfLevels.Add(sum / i);
                numOfNodes = childNodesAtSameLevel.Count;
                for (int j = 0; j < numOfNodes; j++)
                {
                    allParentNodesAtSameLevel.Enqueue(childNodesAtSameLevel.Dequeue());
                }
            }
            return avgOfLevels;
        }
    }
}
