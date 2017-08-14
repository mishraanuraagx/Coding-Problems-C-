using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class CanWinNim
    {
        public static void run()
        {
            Console.WriteLine(CanWinNimRunner(4));
        }

        public static bool CanWinNimRunner(int n)
        {

            return n % 4 == 0 ? false : true;
        }
    }
}
