using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // 26. https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
    public class RemoveDuplicatesSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            // handle zero case
            if (nums.Length == 0) return 0;

            int pointer = 1; // pointer to place the next unique element

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1]) // if not equal to element to left
                {
                    nums[pointer] = nums[i]; // place unique elment at the next position
                    pointer++; // increment the unique element position pointer
                }           
                
            }
            return pointer;
        }
    }
}
