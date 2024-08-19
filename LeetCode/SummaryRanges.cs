using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SummaryRangesSolution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> result = new List<string>();

            if (nums.Length == 0)
            {
                return result;
            }

            int start = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                // check if current number is not consecutive with previous one, previous range ends here
                if (nums[i] != nums[i - 1] + 1)
                {
                    // if range contains only a single number, add the number itself to result
                    if (start == nums[i - 1])
                    {
                        result.Add(start.ToString());
                    }
                    else
                    {
                        result.Add(start + "->" + nums[i - 1]);
                    }
                    // update the start of the new range
                    start = nums[i];
                }
            }
            // add the last range
            if (start == nums[nums.Length - 1])
            {
                result.Add(start.ToString());
            }
            else
            {
                result.Add(start + "->" + nums[nums.Length - 1]);
            }
            return result;
        }
    }
}
