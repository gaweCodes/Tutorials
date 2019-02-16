using NUnit.Framework;

namespace SortingMethods.Tests
{
    [TestFixture]
    public class BubbleSortTests
    {
        [Test]
        public void OnlyPositiveNumbers_BubbleSort()
        {
            var bubbleSort = new BubbleSort();
            var numbers = new double[] { 5, 9, 3, 9, 10, 9, 2, 4, 13, 10 };
            var expected = new double[] { 2, 3, 4, 5, 9, 9, 9, 10, 10, 13 };
            bubbleSort.Sort(numbers);
            Assert.AreEqual(expected, numbers);
        }

        [Test]
        public void PositiveAndNegativeNumbers_BubbleSort()
        {
            var bubbleSort = new BubbleSort();
            var numbers = new double[] { 5, 9, -3, 9, 10, 9, -2, 4, 13, 10 };
            var expected = new double[] { -3, -2, 4, 5, 9, 9, 9, 10, 10, 13 };
            bubbleSort.Sort(numbers);
            Assert.AreEqual(expected, numbers);
        }

        [Test]
        public void DecimalNumbers_BubbleSort()
        {
            var bubbleSort = new BubbleSort();
            var numbers = new[] { 5.2, 9.3, -3, 9.2, 10.4, 9.6, -2, 4, 13, 10.7 };
            var expected = new[] { -3, -2, 4, 5.2, 9.2, 9.3, 9.6, 10.4, 10.7, 13 };
            bubbleSort.Sort(numbers);
            Assert.AreEqual(expected, numbers);
        }

        [Test]
        public void Characters_BubbleSort()
        {
            var bubbleSort = new BubbleSort();
            var word = "dbca".ToCharArray();
            var expected = "abcd".ToCharArray();
            bubbleSort.Sort(word);
            Assert.AreEqual(expected, word);
        }
    }
}
