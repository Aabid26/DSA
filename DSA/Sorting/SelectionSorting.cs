using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    /// <summary>
    /// Selects the minimum element and places it at the beginning.
    /// 
    /// Time Complexity: O( n2 )O(n2)
    /// 
    /// Easy to implement, but not optimal
    /// </summary>
    public class SelectionSorting : ISort
    {
        private static Lazy<SelectionSorting> selectionInstance= new Lazy<SelectionSorting>(() => new SelectionSorting());
        public static SelectionSorting Instance= selectionInstance.Value;

        public List<int> sort(List<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                int smallestNum = int.MaxValue;
                int index = 0;
                for (int j = i; j < list.Count; j++)
                {
                    // selecting the index of smallest number in list
                    if(list[j] < smallestNum)
                    {
                        smallestNum=list[j];
                        index = j;
                    }
                }
                // placing the number from smallest to largest in list. 
                int temp = list[index];
                list[index]=list[i];
                list[i] = temp;
            }
            return list;
        }
    }
}
