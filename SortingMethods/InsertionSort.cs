namespace SortingMethods
{
    public class InsertionSort
    {
public void Sort(double[] numbers)
{
    var arrayLength = numbers.Length;
    for (var index = 1; index < arrayLength; index++)
    {
        for (var index1 = index; index1 > 0; index1--)
        {
            if (!(numbers[index1] < numbers[index1 - 1])) continue;
            var temp = numbers[index1];
            numbers[index1] = numbers[index1 - 1];
            numbers[index1 - 1] = temp;
        }
    }
}
public void Sort(char[] chars)
{
    var arrayLength = chars.Length;
    for (var index = 1; index < arrayLength; index++)
    {
        for (var index1 = index; index1 > 0; index1--)
        {
            if (chars[index1] >= chars[index1 - 1]) continue;
            var temp = chars[index1];
            chars[index1] = chars[index1 - 1];
            chars[index1 - 1] = temp;
        }
    }
}
    }
}
