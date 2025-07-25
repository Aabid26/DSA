using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    public class MergeSorting : ISort
    {
        private static readonly Lazy<MergeSorting> _Instance = new Lazy<MergeSorting>(() => new MergeSorting());
        public static MergeSorting Instance = _Instance.Value;
        public List<int> sort(List<int> list)
        {
            if (list.Count <= 1)
                return list;

            int mid = list.Count / 2;

            //Divide the list into half
            var firstHalf = list.GetRange(0, mid);
            var secondHalf = list.GetRange(mid, list.Count-mid);

            //Recursive sort both sides
            var left = MergeSorting.Instance.sort(firstHalf);
            var right = MergeSorting.Instance.sort(secondHalf);

            //merge and return the sorted half
            return merge(left,right);

        }
        private List<int> merge(List<int> left,List<int> right)
        {
            List<int> result = new List<int>();
            int i = 0;int j = 0;

            //compare the bits and merge
            while (i < left.Count && j < right.Count)
            {
                if(left[i] <= right[j])
                {
                    result.Add(left[i++]);
                }
                else
                {
                    result.Add(right[j++]);
                }
            }

            // merge what's left 
            while (i < left.Count)
                result.Add(left[i++]);
            while (j < right.Count)
                result.Add(right[j++]);

            return result;
        }
    }
}
