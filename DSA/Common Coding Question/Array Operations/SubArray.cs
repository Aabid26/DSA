using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Common_Coding_Question.Array_Operations
{
    public class SubArray
    {
        // 1,2,3,4,5
        public static int[] WithMaximumSum(int[] input)
        {
            int startIndex = 0, endIndex = 0, tempIndex = 0;
            int maxSum = input[0];
            int currentSum = maxSum;
            for(int i=1; i<input.Length; i++)
            {
               
                if (currentSum + input[i] < input[i])
                {
                    tempIndex = i;
                    currentSum = input[i];
                }
                else
                {
                    currentSum += input[i]; // adding the value to sum
                }
                if(currentSum> maxSum)
                {
                    maxSum = currentSum;
                    startIndex = tempIndex; // start index of sub array
                    endIndex = i; // end index of sub array

                }

            }

            return input.Skip(startIndex).Take(endIndex-startIndex+1).ToArray();
        }
    }
}
