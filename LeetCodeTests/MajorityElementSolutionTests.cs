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
    public class MajorityElementSolutionTests
    {
        [TestMethod()]
        public void MajorityElementTest()
        {
            // Arrange
            var finder = new MajorityElementSolution();
            int[] nums = { 3, 2, 3 };

            // Act
            int result = finder.MajorityElement(nums);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void MajorityElementTest_SimpleCase2()
        {
            // Arrange
            var finder = new MajorityElementSolution();
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };

            // Act
            int result = finder.MajorityElement(nums);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void MajorityElementTest_SingleElement()
        {
            // Arrange
            var finder = new MajorityElementSolution();
            int[] nums = { 1 };

            // Act
            int result = finder.MajorityElement(nums);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void MajorityElementTest_AllSameElements()
        {
            // Arrange
            var finder = new MajorityElementSolution();
            int[] nums = { 5, 5, 5, 5 };

            // Act
            int result = finder.MajorityElement(nums);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}