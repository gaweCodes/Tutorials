namespace SortingMethods
{
    public class BubbleSort
    {
        public void Sort(double[] numbers)
        {
            var arrayLength = numbers.Length;
            do
            {
                //To determine if the array is sorted or not.
                var newArraySize = 1;
                for (var index = 0; index < arrayLength - 1; index++)
                {
                    if (numbers[index] > numbers[index + 1])
                    {
                        var tmpValue = numbers[index];
                        numbers[index] = numbers[index + 1];
                        numbers[index + 1] = tmpValue;
                        newArraySize = index + 1;
                    }
                }

                arrayLength = newArraySize;
            } while (arrayLength > 1); // if false: sorting was successfully.
        }
        public void Sort(char[] chars)
        {
            var arrayLength = chars.Length;
            do
            {
                //To determine if the array is sorted or not.
                var newArraySize = 1;
                for (var index = 0; index < arrayLength - 1; index++)
                {
                    if (chars[index] > chars[index + 1])
                    {
                        var tmpValue = chars[index];
                        chars[index] = chars[index + 1];
                        chars[index + 1] = tmpValue;
                        newArraySize = index + 1;
                    }
                }

                arrayLength = newArraySize;
            } while (arrayLength > 1); // if false: sorting was successfully.
        }
    }
}
