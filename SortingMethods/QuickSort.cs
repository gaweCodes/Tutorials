using System.Collections.Generic;

namespace SortingMethods
{
    public class QuickSort
    {
        public void Sort(int left, int right, double[] numbers)
        {
            if (left >= right) return;
            var divider = Divide(left, right, numbers);
            Sort(left, divider - 1, numbers);
            Sort(divider + 1, right, numbers);
        }
        public void Sort(int left, int right, char[] numbers)
        {
            if (left >= right) return;
            var divider = Divide(left, right, numbers);
            Sort(left, divider - 1, numbers);
            Sort(divider + 1, right, numbers);
        }

        private static int Divide(int left, int right, IList<double> numbers)
        {
            var pivot = numbers[right];
            var higherIndex = left;
            var smallerIndex = right - 1;
            double tmpValue;
            do
            {
                //Searching from left to right for an element value higher than the pivot value
                while (numbers[higherIndex] <= pivot && higherIndex < right) higherIndex += 1;

                //Searching from right to left for an element value smaller than the pivot value
                while (numbers[smallerIndex] >= pivot && smallerIndex > left) smallerIndex -= 1;

                //change numbers[higherIndex] with numbers[smallerIndex]
                if (higherIndex >= smallerIndex) continue;
                tmpValue = numbers[higherIndex];
                numbers[higherIndex] = numbers[smallerIndex];
                numbers[smallerIndex] = tmpValue;
            } while (higherIndex < smallerIndex);

            //change pivot element (numbers[right]) with the new final position (numbers[higherIndex])
            if (numbers[higherIndex] <= pivot) return higherIndex; //return the position of the pivot element
            tmpValue = numbers[higherIndex];
            numbers[higherIndex] = numbers[right];
            numbers[right] = tmpValue;
            return higherIndex; //return the position of the pivot element
        }
        private static int Divide(int left, int right, IList<char> numbers)
        {
            var pivot = numbers[right];
            var higherIndex = left;
            var smallerIndex = right - 1;
            int tmpValue;
            do
            {
                //Searching from left to right for an element value higher than the pivot value
                while (numbers[higherIndex] <= pivot && higherIndex < right) higherIndex += 1;

                //Searching from right to left for an element value smaller than the pivot value
                while (numbers[smallerIndex] >= pivot && smallerIndex > left) smallerIndex -= 1;

                //change numbers[higherIndex] with numbers[smallerIndex]
                if (higherIndex >= smallerIndex) continue;
                tmpValue = numbers[higherIndex];
                numbers[higherIndex] = numbers[smallerIndex];
                numbers[smallerIndex] = (char)tmpValue;
            } while (higherIndex < smallerIndex);

            //change pivot element (numbers[right]) with the new final position (numbers[higherIndex])
            if (numbers[higherIndex] <= pivot) return higherIndex; //return the position of the pivot element
            tmpValue = numbers[higherIndex];
            numbers[higherIndex] = numbers[right];
            numbers[right] = (char)tmpValue;
            return higherIndex; //return the position of the pivot element
        }
    }
}
