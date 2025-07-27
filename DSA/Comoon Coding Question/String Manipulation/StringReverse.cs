using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Comoon_Coding_Question.String_Manipulation
{
    public class StringReverse
    {
        public static string  ProcessReverse(string input)
        {
            string final = String.Empty;

            for (int i = input.Length-1; i >= 0 ; i--)
            {
                final += input[i];
            }
            return final;
        }
    }
}
