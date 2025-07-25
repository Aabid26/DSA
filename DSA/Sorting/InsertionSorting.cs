using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    public class InsertionSorting : ISort
    {
        private static Lazy<InsertionSorting> lazyInstance = new Lazy<InsertionSorting>(() => new InsertionSorting());
        public static InsertionSorting Instance = lazyInstance.Value;

        public List<int> sort(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                int key = list[i];
                int j = i - 1;

                // Shift elements of arr[0..i-1] that are greater than key
                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j--;
                }

                // Insert key at correct position
                list[j + 1] = key;

            }
            return list;
        }
    }
}
