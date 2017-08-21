using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class EasyProblems
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
            EasyProblems ep = new EasyProblems();

            //Console.WriteLine(ep.FindTheDifference("aa", "aaa"));


            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(3);
            root.right = new TreeNode(6);
            TreeNode temp;
            temp = root.left;
            temp.left = new TreeNode(2);
            temp.right = new TreeNode(4);
            temp = root.right;
            temp.right = new TreeNode(7);


            //Console.WriteLine(ep.ConvertBST(root).val);

            //Console.WriteLine(ep.Tree2str(root));
            //ep.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
            //ep.MoveZeroes(new int[] { 1 });
            //ep.MoveZeroes(new int[] { 0, 0, 0, 1 });
            //Console.WriteLine(String.Join(", ", ep.ConstructRectangle(40)));
            //Console.WriteLine(String.Join(", ", ep.ConstructRectangle(2)));
            //Console.WriteLine(ep.MaxCount(40000, 40000, new int[,] { { 2, 2 }, { 4, 3 } }));
            //Console.WriteLine(ep.MaxCount(4, 3, new int[,] { }));
            Console.WriteLine(ep.MinMoves(new int[] { 1, 2, 3 }));
        }

        public char FindTheDifference(string s, string t)
        {
            Dictionary<char, int> charList = new Dictionary<char, int>();
            char unknownChar = '0';
            foreach (char c in s)
            {
                int count = 0;
                charList.TryGetValue(c, out count);
                if (count == 0)
                {
                    charList.Add(c, 1);
                }
                else
                {
                    charList[c] = count + 1;
                }
            }

            foreach (char c in t)
            {
                int count = 0;
                charList.TryGetValue(c, out count);
                if (count == 0)
                {
                    unknownChar = c;
                    break;
                }
                else if (count > 0)
                {
                    charList[c] = count - 1;
                }
            }
            return unknownChar;
        }

        public TreeNode ConvertBST(TreeNode root)
        {
            if (root == null) return root;
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);
            SortedDictionary<int, int> reverseSorted = new SortedDictionary<int, int>();

            while (nodeQueue.Count != 0)
            {
                TreeNode temp = nodeQueue.Dequeue();
                reverseSorted.Add(temp.val * -1, temp.val);
                if (temp.left != null)
                {
                    nodeQueue.Enqueue(temp.left);
                }

                if (temp.right != null)
                {
                    nodeQueue.Enqueue(temp.right);
                }

            }

            int sum = 0;
            foreach (KeyValuePair<int, int> node in reverseSorted.ToList())
            {
                sum += node.Value;
                reverseSorted[node.Value * -1] = sum;
                Console.WriteLine(sum);
            }

            nodeQueue.Enqueue(root);
            while (nodeQueue.Count != 0)
            {
                TreeNode temp = nodeQueue.Dequeue();
                temp.val = reverseSorted[temp.val * -1];
                if (temp.left != null)
                {
                    nodeQueue.Enqueue(temp.left);
                }

                if (temp.right != null)
                {
                    nodeQueue.Enqueue(temp.right);
                }
            }

            return root;
        }

        public string Tree2str(TreeNode t)
        {
            //TODO max: need fixng
            int closingBraceIndicatorValue = int.MaxValue;
            int nullIndicatorValue = int.MinValue;

            Stack<TreeNode> nodeStack = new Stack<TreeNode>();
            nodeStack.Push(t);

            StringBuilder tree2strBuilder = new StringBuilder();
            while (nodeStack.Count != 0)
            {
                TreeNode temp = nodeStack.Pop();
                if (temp.val == int.MaxValue)
                {
                    tree2strBuilder.Append(")");
                }
                else if (temp.val == int.MinValue)
                {
                    tree2strBuilder.Append("()");
                }
                else
                {
                    tree2strBuilder.Append("(");
                    tree2strBuilder.Append(temp.val);
                    if (temp.right == null)
                    {
                        nodeStack.Push(new TreeNode(nullIndicatorValue));
                    }
                    else
                    {
                        nodeStack.Push(new TreeNode(closingBraceIndicatorValue));
                        nodeStack.Push(temp.right);
                    }

                    if (temp.left == null)
                    {
                        nodeStack.Push(new TreeNode(nullIndicatorValue));
                    }
                    else
                    {
                        nodeStack.Push(new TreeNode(closingBraceIndicatorValue));
                        nodeStack.Push(temp.left);
                    }


                }


            }

            return tree2strBuilder.ToString().Substring(1, tree2strBuilder.Length - 2);
        }

        public void MoveZeroes(int[] nums)
        {
            if (nums.Length <= 0) return;

            int firstZeroIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    firstZeroIndex = i;
                    break;
                }
            }

            //if (firstZeroIndex == -1) return;

            for (int i = 0; i < nums.Length; i++)
            {
                if (firstZeroIndex == -1) break;
                if (firstZeroIndex >= nums.Length)
                {
                    break;
                }
                if (i <= firstZeroIndex)
                {
                    continue;
                }
                else if (nums[i] == 0)
                {
                    continue;
                }
                else
                {

                    nums[firstZeroIndex] = nums[i];
                    nums[i] = 0;
                    //This loop only runs for n times at max, so its still O(n) to run this
                    for (int j = firstZeroIndex; j < nums.Length; j++)
                    {
                        if (nums[j] == 0)
                        {
                            firstZeroIndex = j;
                            break;
                        }
                    }
                }


            }

            //Console.WriteLine(string.Join(", ", nums));
        }

        public int[] ConstructRectangle(int area)
        {
            int width = (int)Math.Sqrt(area);
            while (area % width != 0)
            {
                width--;
            }

            return new int[] { area / width, width };
        }

        public int MaxCount(int m, int n, int[,] ops)
        {
            int[] firstRow = new int[m];
            int[] firstCol = new int[n];


            //iterate through first row and first col only
            for (int i = 0; i < ops.GetLength(0); i++)
            {
                int j = ops[i, 0], k = ops[i, 1];
                for (int p = 0; p < j; p++)
                {
                    firstRow[p]++;
                }

                for (int o = 0; o < k; o++)
                {
                    firstCol[o]++;
                }



            }


            //checking for first row only
            int maxValue = firstCol[0];
            int a = 0, b = 0;
            for (a = 0; a < m; a++)
            {
                if (firstRow[a] != maxValue)
                {
                    break;
                }
            }

            //checking for first col only
            for (b = 0; b < n; b++)
            {
                if (firstCol[b] != maxValue)
                {
                    break;
                }
            }
            return a * b;
        }

        public int MinMoves(int[] nums)
        {
            Dictionary<int, int> numsMap = new Dictionary<int, int>();
            int min = int.MaxValue;
            foreach (var item in nums)
            {
                if (item < min)
                {
                    min = item;
                }
                int count = 0;
                numsMap.TryGetValue(item, out count);
                if (count == 0)
                {
                    numsMap.Add(item, 1);
                }
                else
                {
                    numsMap[item]++;
                }
            }
            int minMoves = 0;

            foreach (var item in numsMap)
            {
                minMoves += (item.Key - min) * item.Value;
            }
            return minMoves;
        }
    }
}
