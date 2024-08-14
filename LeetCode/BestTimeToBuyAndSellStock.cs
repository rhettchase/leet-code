using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{ // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            // return max profit you can achieve from transaction
            int largestDifference = 0;
            int minSoFar = int.MaxValue; // also known as the best buy day so far

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minSoFar) // set minSoFar to price if its less than what has been seen so far
                { 
                    minSoFar = prices[i]; 
                }
                else
                // executes when the current price is not lower
                // check whether selling on this day with the current price would give better profit than any recorded previously (largestDifference)
                // compare potential profit with teh best profit recorded so far and updates if it is greater
                {
                    largestDifference = Math.Max(largestDifference, prices[i] - minSoFar);
                }
            }
            return largestDifference;

        }
    }
}
