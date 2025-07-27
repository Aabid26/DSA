using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Comoon_Coding_Question.String_Manipulation
{
     public class IsPalindrome
    {
        public static bool Check(string input)
        {
            input = input.ToLower();
            bool result = false;
            for (int i =0;i<input.Length/2;i++)
            {
                if(input[i] == input[input.Length - (i + 1)])
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
