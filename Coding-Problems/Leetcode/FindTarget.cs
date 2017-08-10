using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    class FindTarget
    {

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

            Console.WriteLine(FindTargetRunner(root, 9));
        }

        public static bool FindTargetRunner(TreeNode root, int k)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            ArrayList reqNumberList = new ArrayList();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                TreeNode temp = q.Dequeue();
                if (reqNumberList.Contains(temp.val))
                {
                    return true;
                }
                else
                {
                    if(temp.left != null)
                    {
                        q.Enqueue(temp.left);
                    }
                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                    }
                    
                    reqNumberList.Add(k - temp.val);
                }

            }
            return false;
        }
    }


}
