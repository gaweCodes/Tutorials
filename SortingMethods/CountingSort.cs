namespace SortingMethods
{
    public class CountingSort
    {
        public int[] Sort(int[] numbers)
        {
            var arrayLength = numbers.Length;
            //Get the maximum value of the parameter
            var max = numbers[0];
            for (var index = 0; index < arrayLength; index++)
            {
                // is the current value of the array greater than the current maximum?
                // if yes: Set the current array value as new maximum
                if (max < numbers[index])
                    max = numbers[index];
            }

            //create the array for the sorted numbers. It becomes the size of the max + 1
            var sortedNumbers = new int[max + 1];
            //Iterate through the indexes of the numbers array
            for (var index = 0; index < arrayLength; index++)
            {
                // Count how much times every number occurs.
                // Then save this value in sortedNumbers[] at index number[index]
                sortedNumbers[numbers[index]]++;
            }

            //insertPosition holds the the index which shows where to write a value in the output array.
            var insertPosition = 0;
            //Iterate through indexes of sortedNumbers[] to check how much times every number occurs
            for (var index = 0; index <= max; index++)
            {
                //Iterate the sortedNumbers array to write equal numbers in a row
                for (var index1 = 0; index1 < sortedNumbers[index]; index1++)
                {
                    //Sort and rewrite the numbers array.
                    //It writes the correct value (from sorted list) to the correct index of numbers array.
                    numbers[insertPosition++] = index;
                }
            }

            //return the sorted array.
            return numbers;
        }
    }
}
