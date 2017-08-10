using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class ReverseWords
    {
        public static void run()
        {
            Console.WriteLine(ReverseWordsRunner("Let's take LeetCode contest"));
        }

        public static string ReverseWordsRunner(string s)
        {
            string[] allWords = s.Split(' ');
            StringBuilder reverse = new StringBuilder();
            foreach (string word in allWords)
            {
                int n = word.Length;
                for (int i = 0; i < n; i++)
                {
                    reverse.Append(word[n - i - 1]);
                }
                reverse.Append(" ");
            }
            return reverse.ToString().Remove(reverse.Length-1);
        }
    }
}
