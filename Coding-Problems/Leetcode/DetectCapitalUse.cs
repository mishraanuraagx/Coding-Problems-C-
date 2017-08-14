using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class DetectCapitalUse
    {
        public static void run()
        {
            Console.WriteLine(DetectCapitalUseRunner("geneRal"));
        }

        public static bool DetectCapitalUseRunner(string word)
        {
            return (word.Equals(word.ToLower()) || word.Equals(word.ToUpper()) || word.Substring(1).Equals(word.ToLower().Substring(1))) ? true : false;

        }
    }
}
