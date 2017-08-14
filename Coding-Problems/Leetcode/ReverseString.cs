using System;
using System.Text;
namespace Coding_Problem
{
    class ReverseString
    {

        public static void run()
        {
            String s = Console.ReadLine();
            s = ReverseS(s);
            Console.WriteLine(s);
            Console.ReadLine();
        }

        public static String ReverseS(string s)
        {
            char[] c = s.ToCharArray();
            /*
             *Array.Reverse(c);
             */
            StringBuilder ReverseString = new StringBuilder();
            for (int i = c.Length - 1; i >= 0; i--)
            {
                ReverseString.Append(c[i]);
            }

            return ReverseString.ToString();

        }

    }

    class printArray
    {
        public static void run()
        {
            //from string literal and string concatenation

            Console.WriteLine("The length of this array is >>>>>>");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int i in arr)
            {
                Console.Write("Element at {0} index is = {1}", i, i);
            }
            Console.ReadKey();
        }
    }
}
