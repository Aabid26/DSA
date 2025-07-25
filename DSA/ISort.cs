using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public interface ISort
    {
        /// <summary>
        /// Virtual Method to Sort list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        List<int> sort(List<int> list);
        
    }
}
