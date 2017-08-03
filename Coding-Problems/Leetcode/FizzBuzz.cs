using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class FizzBuzz
    {

        public static void run()
        {
            IList<String> stringList = FizzBuzz.FizzBuzzRunner();

            Console.WriteLine(String.Join(",", stringList.ToList().ToArray()));
        }
        public static IList<String> FizzBuzzRunner()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            String[] stringList = new String[n];
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    //Console.WriteLine("FizzBuzz");
                    stringList[i - 1] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    //Console.WriteLine("Fizz");
                    stringList[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    //Console.WriteLine("Buzz");
                    stringList[i - 1] = "Buzz";
                }
                else
                {
                    stringList[i - 1] = i + "";
                }
            }

            return stringList;
        }
    }
}
