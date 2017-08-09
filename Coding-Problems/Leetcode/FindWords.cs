using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below. */

namespace Coding_Problems.Leetcode
{
    class FindWords
    {
        public static void run()
        {
            string[] stringList = { "Hello", "Alaska", "Dad", "Peace" };
            Console.WriteLine(String.Join(",", FindWordsRunner(stringList)));


        }
        public static string[] FindWordsRunner(string[] words)
        {
            char[] topRow = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', };
            char[] midRow = { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            char[] botRow = { 'z', 'x', 'c', 'v', 'v', 'b', 'n', 'm' };


            ArrayList reqWords = new ArrayList();
            foreach (string word in words)
            {
                string wordTemp = word.ToLower();
                bool isItSpecialWord = false;
                bool isItMadeFromTopRow = true;
                bool isItMadeFromMidRow = true;
                bool isItMadeFromBotRow = true;


                foreach (char letter in wordTemp)
                {


                    if (isItMadeFromTopRow && !topRow.Contains(letter))
                    {
                        isItMadeFromTopRow = false;
                    }
                    if (isItMadeFromMidRow && !midRow.Contains(letter))
                    {
                        isItMadeFromMidRow = false;
                    }
                    if (isItMadeFromBotRow && !botRow.Contains(letter))
                    {
                        isItMadeFromBotRow = false;
                    }

                    isItSpecialWord = isItMadeFromTopRow || isItMadeFromMidRow || isItMadeFromBotRow;

                }
                if (isItSpecialWord)
                {
                    reqWords.Add(word);
                }
            }


            return (string[])reqWords.ToArray(typeof(string));
        }
    }
}
