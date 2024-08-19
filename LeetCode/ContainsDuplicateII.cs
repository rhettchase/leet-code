using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{ // # 219 - https://leetcode.com/problems/contains-duplicate-ii
    public class ContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            HashSet<int> seen = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (seen.Contains(nums[i]))
                {
                    return true; // duplicate found
                }
                seen.Add(nums[i]);

                // remove the element that's out of the window
                if (i >= k)
                {
                    seen.Remove(nums[i - k]); // remove the element that is k positions back 
                }
            }
            return false; // no duplicates found
        }
    }
}
