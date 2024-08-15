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
    public class IsomorphicStringsTests
    {
        [TestMethod()]
        public void IsIsomorphicTest()
        {
            // arrange
            var sol = new IsomorphicStrings();

            // act
            string s = "egg";
            string t = "add";
            bool result = sol.IsIsomorphic(s, t);

            // assert
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void IsIsomorphicTest2()
        {
            // arrange
            var sol = new IsomorphicStrings();

            // act
            string s = "foo";
            string t = "bar";
            bool result = sol.IsIsomorphic(s, t);

            // assert
            Assert.IsFalse(result);
        }
    }
}