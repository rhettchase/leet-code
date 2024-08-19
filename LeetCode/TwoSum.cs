using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (dic.ContainsKey(complement))
                {
                    // return results direclty when complement is found
                    return new int[] { i, dic[complement] };

                }
                // add only if the key does not exist to avoid exceptions
                dic[nums[i]] = i;
            }
            return null;
        }
    }
}
