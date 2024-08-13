using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{ // 169: https://leetcode.com/problems/majority-element/description/
    public class MajorityElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> majorityDictionary = new Dictionary<int, int>();
            int cutoff = nums.Length / 2;

            foreach(int num in nums)
            {
                // check if it's in dictionary; if yes then increment the count
                if (majorityDictionary.ContainsKey(num))
                {
                    majorityDictionary[num] += 1; // add each integer to dictionary and increment the count of times seen (value)
                }
                else
                {
                    majorityDictionary[num] = 1; // initialize count if key doesn't exist
                }
                
            }

            foreach(var keyValuePair in majorityDictionary)
            {
               if (keyValuePair.Value > cutoff)
                { return keyValuePair.Key; }; // return key (number) with count greater than cutoff
            }

            return -1; // if not majority found
        }
    }
}
