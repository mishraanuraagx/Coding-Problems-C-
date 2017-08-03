using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class LongestPalindrome
    {
        public static void run()
        {
            String s = "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";
            String s1 = "abccccdd";
            int n = LongestPalindrome.LongestPalindromeRunner(s1);
            Console.WriteLine(n);
        }

        public static int LongestPalindromeRunner(string s)
        {
            char[] c = s.ToCharArray();
            var myHashMap = new Dictionary<char, int>();

            foreach (char r in c)
            {
                int occourence = 0;
                myHashMap.TryGetValue(r, out occourence);
                myHashMap[r] = occourence + 1;
            }

            int range = 0, maxOccurenceOfOddValue = 0;
            Boolean anyOddCount = false;
            foreach (var map in myHashMap)
            {
                //Console.WriteLine(map.Key + ":" + map.Value);

                //Console.WriteLine(map.Value);
                if (map.Value % 2 == 0)
                {
                    range += map.Value;
                }
                else
                {
                    anyOddCount = true;


                    range += map.Value - 1;
                }



            }
            if (anyOddCount)
            {
                return range + 1;
            }
            return range;
        }
    }
}
