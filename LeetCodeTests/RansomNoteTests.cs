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
    public class RansomNoteTests
    {
        [TestMethod()]
        public void CanConstructTest()
        {
            // arrange
            var note = new RansomNote();

            // act
            string ransomNote = "a";
            string magazine = "b";
            bool result = note.CanConstruct(ransomNote, magazine);

            // assert
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void CanConstructTest2()
        {
            // arrange
            var note = new RansomNote();

            // act
            string ransomNote = "aa";
            string magazine = "ab";
            bool result = note.CanConstruct(ransomNote, magazine);

            // assert
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void CanConstructTest3()
        {
            // arrange
            var note = new RansomNote();

            // act
            string ransomNote = "aa";
            string magazine = "aab";
            bool result = note.CanConstruct(ransomNote, magazine);

            // assert
            Assert.IsTrue(result);
        }
    }
}