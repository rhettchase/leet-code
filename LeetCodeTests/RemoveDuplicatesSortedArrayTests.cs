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
    public class RemoveDuplicatesSortedArrayTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            // Arrange
            var solution = new RemoveDuplicatesSortedArray();
            int[] nums = { 1, 1, 2 };
            int[] expectedNums = { 1, 2 }; // Expected array after removing duplicates
            int expectedLength = expectedNums.Length; // Expected length of unique elements

            // Act
            int k = solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expectedLength, k); // Check if the length is as expected

            // Check if the elements in nums match the expected elements
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(expectedNums[i], nums[i]);
            }
        }
    
    }
}