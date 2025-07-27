using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Common_Coding_Question.String_Manipulation
{
    public class Character_Occurance
    {
        public static int Count(string input, char ch)
        {
            int ch_ASCII = (int)ch;
            int count = 0;
            input = input.ToLower(); // case-Insensitive.
            foreach (char c in input) { if (ch_ASCII == (int)c) count++; }
            return count;
        }
    }
}
