using NUnit.Framework;

namespace SortingMethods.Tests
{
    [TestFixture]
    public class CountingSortTests
    {
        [Test]
        public void OnlyPositiveNumbers_CountingSort()
        {
            var countingSort = new CountingSort();
            var numbers = new[] { 5, 9, 3, 9, 10, 9, 2, 4, 13, 10 };
            var expected = new[] { 2, 3, 4, 5, 9, 9, 9, 10, 10, 13 };
            var result = countingSort.Sort(numbers);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void NormalArray_CountingSort()
        {
            var countingSort = new CountingSort();
            var numbers = new[] { 2, 3, 1, 10, 5, 4, 6, 8, 7, 9 };
            var expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = countingSort.Sort(numbers);
            Assert.AreEqual(expected, result);
        }
    }
}
