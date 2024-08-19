using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            HashSet<int> seen = new HashSet<int>();

            while (n != 1)
            {
                if (seen.Contains(n))
                {
                    return false; // cycle detected, return false since not a happy number
                }
                seen.Add(n);
                n = sumOfSquares(n);
            }
            return true; // n is 1, return true since it's a happy number
        }

        private int sumOfSquares(int num)
        {
            int sum = 0;

            // loop through each digit
            while (num > 0)
            {
                int digit = num % 10; // extract last digit
                sum += (digit * digit); // add the square of the digit to the sum
                num /= 10; // remove last digit from num by performing integer division
            }
            return sum;
        }
    }
}
