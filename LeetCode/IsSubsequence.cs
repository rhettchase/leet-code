using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsSubsequenceSolution
    {
        public bool IsSubsequence(string s, string t)
        {
            int pointerS = 0;
            int pointerT = 0;

            while (pointerS < s.Length && pointerT < t.Length) // loop continues as long as both pointers are within bounds of their strings
            {
                if (s[pointerS] == t[pointerT])
                {
                    pointerS++;
           
                }
                pointerT++; // always advance pointerT, regardless of match
            }
            // If pointerS reached the end of s, it means all characters in s were found in t in order
            return pointerS == s.Length;
        }
    }
}
