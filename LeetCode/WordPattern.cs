using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{ // 290 - https://leetcode.com/problems/word-pattern/description/
    public class WordPatternSolution
    {
        public bool WordPattern(string pattern, string s)
        {
            string[] words = s.Split(' ');

            // if lengths don't match, pattern can't apply
            if (pattern.Length != words.Length) { return false; }

            Dictionary<char, string> patternToWordMap = new Dictionary<char, string>();
            Dictionary<string, char> wordToPatternMap = new Dictionary<string, char>();

            // iterate over the chars in pattern and corresponding words w in words
            for (int i = 0; i < pattern.Length; i++)
            {
                char char_p = pattern[i];
                string word_w = words[i];

                // check patter to word mapping
                if (patternToWordMap.ContainsKey(char_p)) // check if p already in map
                {
                    if (patternToWordMap[char_p] != word_w) { return false; } // inconsistent maping
                }
                else
                {
                    patternToWordMap[char_p] = word_w; // if not in map, add p as key with w as value
                }
                // check word to pattern mapping
                if (wordToPatternMap.ContainsKey(word_w))
                {
                    if (wordToPatternMap[word_w] != char_p) { return false; } // inconsistent mapping
                }
                else
                {
                    wordToPatternMap[word_w] = char_p; // if not in map, add w as key and p as value
                }
            }
            return true; // all mappings are consistent
        }
    }
}
