using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{ // #13 - https://leetcode.com/problems/roman-to-integer/
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanDict = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // Get the value of the current Roman numeral
                int currentValue = romanDict[s[i]];

                // check if next numeral exists (in bounds) and is greater than the current (subtraction case)
                if (i < s.Length - 1 && currentValue < romanDict[s[i + 1]])
                {
                    result -= currentValue;
                }
                else
                {
                    result += currentValue;
                }
            }
            return result;
        }
    }
}
