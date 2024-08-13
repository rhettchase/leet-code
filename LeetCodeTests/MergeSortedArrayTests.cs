using LeetCode;

namespace LeetCodeTests
{
    [TestClass]
    public class MergeSortedArrayTests
    {
        [TestMethod]
        public void MergeTest1()
        {
            // arrange
            MergeSortedArray m = new MergeSortedArray();

            // act
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int[] nums2 = [2, 5, 6];
            int[] expected = [1, 2, 2, 3, 5, 6];
            m.Merge(nums1, 3, nums2, 3);

            // assert
            CollectionAssert.AreEqual(expected, nums1);
        }
        [TestMethod]
        public void MergeTest2()
        {
            // arrange
            MergeSortedArray m = new MergeSortedArray();

            // act
            int[] nums1 = [1];
            int[] nums2 = [];
            int[] expected = [1];
            m.Merge(nums1, 1, nums2, 0);

            // assert
            CollectionAssert.AreEqual(expected, nums1);
        }
        [TestMethod]
        public void MergeTest3()
        {
            // arrange
            MergeSortedArray m = new MergeSortedArray();

            // act
            int[] nums1 = [0];
            int[] nums2 = [1];
            int[] expected = [1];
            m.Merge(nums1, 0, nums2, 1);

            // assert
            CollectionAssert.AreEqual(expected, nums1);
        }
    }
}