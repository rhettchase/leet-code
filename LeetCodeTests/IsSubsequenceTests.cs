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
    public class IsSubsequenceTests
    {
        [TestMethod()]
        public void IsSubsequenceTest()
        {
            // arrange
            var solution = new IsSubsequenceSolution();

            // act
            string s = "abc";
            string t = "ahbgdc";
            bool result = solution.IsSubsequence(s, t);

            // assert
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void IsSubsequenceTest2()
        {
            // arrange
            var solution = new IsSubsequenceSolution();

            // act
            string s = "axc";
            string t = "ahbgdc";
            bool result = solution.IsSubsequence(s, t);

            // assert
            Assert.IsFalse(result);
        }
    }
}