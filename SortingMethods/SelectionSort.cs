namespace SortingMethods
{
    public class SelectionSort
    {
public void Sort(double[] numbers)
{
    var arrayLength = numbers.Length;
    for (var index = 1; index < arrayLength; index++)
    {
        var key = numbers[index];
        var index2 = index - 1;
        
        // Move elements of arr[0..i-1], that are greater than key, to one position ahead of their current position
        while (index2 >= 0 && numbers[index2] > key)
        {
            numbers[index2 + 1] = numbers[index2];
            index2--;
        }
        numbers[index2 + 1] = key;
    }
}
public void Sort(char[] numbers)
{
    var arrayLength = numbers.Length;
    for (var index = 1; index < arrayLength; index++)
    {
        var key = numbers[index];
        var index2 = index - 1;

        // Move elements of arr[0..i-1], that are greater than key, to one position ahead of their current position
        while (index2 >= 0 && numbers[index2] > key)
        {
            numbers[index2 + 1] = numbers[index2];
            index2--;
        }
        numbers[index2 + 1] = key;
    }
}
    }
}