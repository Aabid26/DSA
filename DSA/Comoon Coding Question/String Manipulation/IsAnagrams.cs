using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Comoon_Coding_Question.String_Manipulation
{
    public class IsAnagrams
    {
        public static bool Check(string input1 , string input2)
        {
            if(input1.Length != input2.Length)
            {
                return false;
            }
            int[] charArray = new int[256]; // ASCII number;
            foreach (char  c in input1) 
                charArray[c]++; // all char are increased as their occurance.
            foreach (char c in input2) charArray[c]--; // all char are decreased as per their occurance

            return charArray.All(c => c == 0); // All char are 0
        } 
    }
}
