using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // problem 27: https://leetcode.com/problems/remove-element/
    public class RemoveElementSolution
    {
        public int RemoveElement(int[] nums, int val)
        {

            // remove all occurences of val in nums in-place
            // return the number of elements in nums which are NOT equal to val (k)
            int pointer = 0; // track next position for valid element

            // iterate througha array
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[pointer] = nums[i]; // move valid element to position of pointer
                    pointer++; // increment pointer to next position
                }
            }

            // replace remaining elements with underscores
            for (int i = pointer; i < nums.Length; i++)
            {
                nums[i] = '_'; // replace with underscore
            }

            return pointer;
        }
    }
}
