using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class GetSum
    {
        public static void run()
        {
            Console.WriteLine(GetSumRunner(2, 3));
        }

        public static int GetSumRunner(int a, int b)
        {
            while (b != 0)
            {
                int carry = a & b;
                a = a ^ b;
                b = carry<<1;
            }
            return a;
        }
    }
}
