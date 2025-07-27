using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Comoon_Coding_Question.Array_Operations
{
    public class Maximum_Element
    {
        public static int Find(int[] input)
        {
            // sorted the array first (asc order)
           var sortedList= Sorting.BubbleSorting.Instance.sort(input.ToList());
           var sortedArr = sortedList.ToArray();
            //extracted the last arr
           return sortedArr[sortedArr.Length - 1];
        }
    }
}
