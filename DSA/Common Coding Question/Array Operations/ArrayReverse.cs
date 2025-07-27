using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Common_Coding_Question.Array_Operations
{
    public class ArrayReverse
    {
        public static int[] Reverse(int[] input)
        {
            int[] reversed = new int[input.Length];
            int iterator = 0;
            for (int i = input.Length-1; i>=0; i--)
            {
                reversed[iterator] = input[i];
                iterator++;
            }
            return reversed;
        }
    }
}
