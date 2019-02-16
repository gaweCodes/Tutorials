using NUnit.Framework;

namespace SortingMethods.Tests
{
    [TestFixture]
    public class QuickSortTests
    {
        [Test]
        public void OnlyPositiveNumbers_QuickSort()
        {
            var quickSort = new QuickSort();
            var numbers = new double[] { 5, 9, 3, 9, 10, 9, 2, 4, 13, 10 };
            var expected = new double[] { 2, 3, 4, 5, 9, 9, 9, 10, 10, 13 };
            quickSort.Sort(0,numbers.Length - 1, numbers);
            Assert.AreEqual(expected, numbers);
        }

        [Test]
        public void PositiveAndNegativeNumbers_QuickSort()
        {
            var quickSort = new QuickSort();
            var numbers = new double[] { 5, 9, -3, 9, 10, 9, -2, 4, 13, 10 };
            var expected = new double[] { -3, -2, 4, 5, 9, 9, 9, 10, 10, 13 };
            quickSort.Sort(0, numbers.Length - 1, numbers);
            Assert.AreEqual(expected, numbers);
        }

        [Test]
        public void DecimalNumbers_QuickSort()
        {
            var quickSort = new QuickSort();
            var numbers = new[] { 5.2, 9.3, -3, 9.2, 10.4, 9.6, -2, 4, 13, 10.7 };
            var expected = new[] { -3, -2, 4, 5.2, 9.2, 9.3, 9.6, 10.4, 10.7, 13 };
            quickSort.Sort(0, numbers.Length - 1, numbers);
            Assert.AreEqual(expected, numbers);
        }

        [Test]
        public void Characters_QuickSort()
        {
            var quickSort = new QuickSort();
            var word = "dbca".ToCharArray();
            var expected = "abcd".ToCharArray();
            quickSort.Sort(0, word.Length - 1, word);
            Assert.AreEqual(expected, word);
        }
    }
}
