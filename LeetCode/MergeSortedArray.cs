using System.Runtime.CompilerServices;

namespace LeetCode
{ // problem 88: https://leetcode.com/problems/merge-sorted-array/description/
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
           
            int pointer1 = m - 1;
            int pointer2 = n - 1;

            // empty case - copy array and return
            if (m == 0) { Array.Copy(nums2, nums1, nums1.Length); return; }
            
            for (int i = nums1.Length - 1; i >= 0; i--) // for loop, starting at end of nums1 array
            {
                
                if (pointer2 < 0) break; // If all elements from nums2 are merged, exit loop

                // checks if there are still elements part of the original nums1 array
                // compares largest unmerged element in nums1 with largest unmerged element in nums2
                if (pointer1 >= 0 && nums1[pointer1] > nums2[pointer2])
                {
                    nums1[i] = nums1[pointer1]; // place element from nums1 into current position
                    pointer1 -= 1; // move pointer one position to the left
                }
                else
                {
                    nums1[i] = nums2[pointer2]; // element from nums2 should be placed into current position
                    pointer2 -= 1; // Move pointer2 left to the next element in nums2
                }

            }
        }
    }
}
