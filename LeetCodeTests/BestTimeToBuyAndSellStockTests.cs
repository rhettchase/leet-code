using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class BestTimeToBuyAndSellStockTests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            // arrange
            BestTimeToBuyAndSellStock solution = new BestTimeToBuyAndSellStock();

            // act
            int[] prices = [7, 1, 5, 3, 6, 4];
            int answer = solution.MaxProfit(prices);
            int expected = 5;

            // assert
            Assert.AreEqual(expected, answer);

        }
        [TestMethod()]
        public void MaxProfitTest_ZeroProfit()
        {
            // arrange
            BestTimeToBuyAndSellStock solution = new BestTimeToBuyAndSellStock();

            // act
            int[] prices = [7, 6, 4, 3, 1];
            int answer = solution.MaxProfit(prices);
            int expected = 0;

            // assert
            Assert.AreEqual(expected, answer);

        }
    }
}