using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LeetCode.Tests
{
    [TestClass()]
    public class RemoveElementTests
    {

        [TestMethod()]
        public void RemoveElementTest()
        {
            // arrange
            RemoveElementSolution solution = new RemoveElementSolution();

            // act
            int[] nums = new int[] { 3, 2, 2, 3 };
            int val = 3;
            int k = solution.RemoveElement(nums, val);
            int[] expected = new int[] { 2, 2, -1, -1 };

            // assert
            Assert.AreEqual(k, 2); // Check if k matches expected length
            for (int i = k; i < nums.Length; i++)
            {
                nums[i] = -1; // Replace remaining elements with -1 to match expected array
            }
            CollectionAssert.AreEqual(expected, nums);
        }
    }
}