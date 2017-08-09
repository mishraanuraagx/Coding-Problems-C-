using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Coding_Problems.Leetcode
{
    class FindComplement
    {
        public static void run()
        {
            Console.WriteLine(FindComplementRunner(5));
        }

        public static int FindComplementRunner(int num)
        {
            byte[] numInBits = BitConverter.GetBytes(num);
            BitArray numInBitArray = new BitArray(numInBits);
            //Console.WriteLine(numInBits.Length);
            //for (int i = 0; i < numInBitArray.Length; i++)
            //{

            //    Console.WriteLine("{0,-6 }", numInBitArray[i]);
            //}
            int indexOfFirstTrueBit = -1;
            for (int i = 0; i < numInBitArray.Count; i++)
            {
                if (numInBitArray[i])
                {
                    indexOfFirstTrueBit = i;
                }
            }
            //Console.WriteLine(indexOfFirstTrueBit);

            BitArray trueBitsFromIndex = new BitArray(numInBitArray.Count);
            for (int i = 0; i <= indexOfFirstTrueBit; i++)
            {
                trueBitsFromIndex[i] = true;
            }
            byte[] complementInBits = new byte[numInBits.Length];
            numInBitArray.Xor(trueBitsFromIndex).CopyTo(complementInBits, 0);
            int complement = BitConverter.ToInt32(complementInBits, 0);
            return complement;
        }
    }
}

