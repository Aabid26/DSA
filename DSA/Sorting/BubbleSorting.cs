using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    /// <summary>
    /// Repeatedly swaps adjacent elements if they are in the wrong order.
   /// Time Complexity: O(n2)On2)
   /// Simple but inefficient for large datasets.
    /// </summary>
    public class BubbleSorting : ISort
    {
        //Singleton Class with LAZY Instance
        private static Lazy<BubbleSorting> lazyInstance = new Lazy<BubbleSorting>(() => new BubbleSorting());
        private BubbleSorting()
        {
            //private contructor
        }
        public static BubbleSorting Instance=lazyInstance.Value;

        public List<int> sort(List<int> list)
        {
            for(int i=0;i<list.Count;i++)
            {
                for (int j= 0;j < list.Count-1;j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        var temp = list[j];
                        list[j]=list[j + 1];
                        list[j+1]=temp;
                    }
                    
                }
            }
            return list;
        }
    }
}
