using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (map.ContainsKey(c))
                {
                    map[c] += 1; // if letter is found, increment value by 1
                }
                else
                {
                    map.Add(c, 1); // if letter not found, create new entry and set value to 1
                }
            }
            foreach (char c in t)
            {
                if (map.ContainsKey(c))
                {
                    map[c] -= 1;
                    if (map[c] == 0)
                    {
                        map.Remove(c);
                    }
                }
                else
                {
                    return false; // if the character wasn't in the dictionary
                }
            }
            return map.Count == 0; // if count of dictionary is 0, it's anagram

        }
    }
}
