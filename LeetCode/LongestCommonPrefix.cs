using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{ // # 14: https://leetcode.com/problems/longest-common-prefix/description/
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            // empty case - return empty string
            if (strs.Length == 0) return "";

            // set initial prefix to assume the first entire string is the common prefix
            string prefix = strs[0];

            // loop through remaining words in the array
            
            // if not, shorten the prefix by removing the last character until the current string starts with it
            // if the prefix becomes empty, return blank string

            for (int i = 1; i < strs.Length; i++)
            {
                // for each string, check if it starts with the current prefix. if it does not, remove last character
                while (!strs[i].StartsWith(prefix))
                {
                    // remove last character from prefix
                    prefix = prefix.Remove(prefix.Length - 1);
                    if (prefix.Length == 0) { return ""; }
                }
                
            }
            return prefix;
        }
    }
}
