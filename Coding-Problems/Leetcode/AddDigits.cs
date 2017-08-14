using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class AddDigits
    {
        public static void run()
        {
            Console.WriteLine(AddDigitsRunner(58));
        }

        public static int AddDigitsRunner(int num)
        {
            while (num > 9)
            {
                string s = num + "";
                int sum = 0;
                foreach (char c in s)
                {
                    sum += Convert.ToInt32(c.ToString());
                }
                num = sum;
            }
            return num;
        }
    }
}
