using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class PrintTree
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
            IList<IList<string>> arrayListOfNodes = PrintTreeRunner(root);
        }
        public static IList<IList<string>> PrintTreeRunner(TreeNode root)
        {
            int depth = depthOfTree(root);
            string[,] treeArrayView = new string[depth, (int)Math.Pow(2, depth) - 1];
            Queue<TreeNode> nodeList = new Queue<TreeNode>();
            int lastMidIndexUsed = ((int)Math.Pow(2, depth) - 1);
            nodeList.Enqueue(root);
            int faultValue = int.MaxValue;
            for (int i = 0; i < depth; i++)
            {
                int newMidIndex = lastMidIndexUsed / 2;
                int gap = lastMidIndexUsed - newMidIndex;
                int placement = newMidIndex;

                for (int j = 0; j < Math.Pow(2, i); j++)
                {
                    TreeNode temp = nodeList.Dequeue();
                    if (j > 0)
                    {
                        //placement = lastMidIndexUsed + gap * j + (j % 2 != 1 ? 1 : 0);
                        placement = placement + (int)Math.Pow(2, depth - i);

                    }
                    if (temp.val != faultValue)
                    {
                        treeArrayView[i, placement] = temp.val + "";
                        Console.Write(temp.val + " ");
                    }
                    else
                    {

                        treeArrayView[i, placement] = "";
                        Console.Write(temp.val + " ");
                    }
                    if (i + 1 != depth)
                    {
                        nodeList.Enqueue(temp.left == null ? new TreeNode(faultValue) : temp.left);
                        nodeList.Enqueue(temp.right == null ? new TreeNode(faultValue) : temp.right);
                    }

                }
                lastMidIndexUsed = newMidIndex;
                Console.WriteLine();

            }


            IList<IList<string>> listOfListOfStrings = new List<IList<string>>();

            for (int i = 0; i < depth; i++)
            {

                List<string> listOfStrings = new List<string>();
                for (int j = 0; j < (int)Math.Pow(2, depth) - 1; j++)
                {
                    if (treeArrayView[i, j] == "" || treeArrayView[i, j] == null)
                    {
                        listOfStrings.Add("");
                    }
                    else
                    {
                        listOfStrings.Add(treeArrayView[i, j]);
                    }
                    Console.Write(treeArrayView[i, j] + " ");
                }
                listOfListOfStrings.Add(listOfStrings);
                Console.WriteLine();
            }
            return listOfListOfStrings;
        }

        public static int depthOfTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(depthOfTree(root.left), depthOfTree(root.right)) + 1;
        }
    }
}
