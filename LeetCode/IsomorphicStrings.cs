using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> sToTmap = new Dictionary<char, char>();
            Dictionary<char, char> tToSmap = new Dictionary<char, char>();

            if (s.Length != t.Length) { return false; }

            // iterate over all characters in string
            for (int i = 0; i < s.Length; i++)
            {
                char char_s = s[i];
                char char_t = t[i];

                // check if char_s is already in the sToTmap
                if (sToTmap.ContainsKey(char_s))
                {
                    if (sToTmap[char_s] != char_t)
                    {
                        return false; //mapping inconsistent
                    }
                }
                else
                {
                    sToTmap[char_s] = char_t; // if not already in map, add it
                }

                if (tToSmap.ContainsKey(char_t))
                {
                    if (tToSmap[char_t] != char_s)
                    {
                        return false; // reverse mapping inconsistent
                    }
                }
                else
                {
                    tToSmap[char_t] = char_s; // if not already in map, add it
                }
            }
            return true;
        }
    }
}
