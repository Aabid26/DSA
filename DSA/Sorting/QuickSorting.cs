using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    public class QuickSorting : ISort
    {
        private static Lazy<QuickSorting> instance = new Lazy<QuickSorting>(() => new QuickSorting());
        public static QuickSorting Instance = instance.Value;

        public List<int> sort(List<int> list)
        {
            List<int> result = new List<int>();

            //pick a host number;
            int pivot = list.Last();
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for(int i = 0; i < list.Count; i++)
            {
               if (list[i] > pivot)
               {
                    // moving the greater number in right side and sorting it.
                   right.Add(list[i]);
                   right.Sort();
               }
               else if (list[i] < pivot)
               {
                    //moving the smaller ones to left array and sorting it 
                   left.Add(list[i]);
                   left.Sort();
               }
                
            }
            //Combining the list together
            result.AddRange(left);
            result.Add(pivot);
            result.AddRange(right);

            return result;
        }
    }
}
