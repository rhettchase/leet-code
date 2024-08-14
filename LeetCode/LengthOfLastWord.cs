using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LengthOfLastWordSolution
    {
        public int LengthOfLastWord(string s)
        {
            // LastIndexOf method

            s = s.Trim();
            int lastSpaceIndex = s.LastIndexOf(' ');
            // calculate length of last word
            int lengthLast = s.Length - lastSpaceIndex - 1;
            return lengthLast;

            // O(n) time complexity


            // loop method
            //s = s.Trim();
            //if (s.Length == 0) return 0;

            //int lengthLast = 0;

            //for (int i = s.Length - 1; i >= 0; i--)
            //{
            //    if (s[i] == ' ')
            //    { break; }
            //    else
            //    {
            //        lengthLast++;
            //    }
            //}
            //return lengthLast;
            // O(n) time complexity - n is length of string
        }
    }
}
