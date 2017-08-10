using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class LongestUncommonSubsequenceI
    {
        public static void run()
        {
            Console.WriteLine(FindLUSlengthRunner("abc", "cdc"));
        }

        public static int FindLUSlengthRunner(string a, string b)
        {
            if (a.Equals(b))
            {
                return -1;
            }
            else
            {
                return Math.Max(a.Length, b.Length);
            }
        }
    }
}
