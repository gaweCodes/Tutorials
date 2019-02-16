namespace SortingMethods
{
    public class CombSort
    {
        public void Sort(double[] numbers)
        {
            var arrayLength = numbers.Length;
            var gap = arrayLength;
            bool changed;
            do
            {
                //Set changed initially to false. This allows to cancel the loop if the is one.
                changed = false;
                for (var index = 0; index < arrayLength; index++)
                {
                    //Ensure that there is no Index out of range exception.
                    if (gap + index >= arrayLength)
                        break;

                    //Checks, if left one is greater than the right one
                    if (!(numbers[index] > numbers[index + gap])) continue;
                    //Yes: change the values
                    var tmpValue = numbers[index];
                    numbers[index] = numbers[index + gap];
                    numbers[index + gap] = tmpValue;
                    changed = true;
                }
                //Shrink gap for next loop
                gap = (int)(gap / 1.3) < 1 ? 1 : (int)(gap / 1.3);
            } while (changed || gap > 1);
        }

        public void Sort(char[] chars)
        {
            var arrayLength = chars.Length;
            var gap = arrayLength;
            
            bool changed;
            do
            {
                //Set changed initially to false. This allows to cancel the loop if the is one.
                changed = false;
                for (var index = 0; index < arrayLength; index++)
                {
                    //Ensure that there is no Index out of range exception.
                    if (gap + index >= arrayLength)
                        break;

                    //Checks, if left one is greater than the right one
                    if (!(chars[index] > chars[index + gap])) continue;
                    //Yes: change the values
                    var tmpValue = chars[index];
                    chars[index] = chars[index + gap];
                    chars[index + gap] = tmpValue;
                    changed = true;
                }
                //Shrink gap for next loop
                gap = (int)(gap / 1.3) < 1 ? 1 : (int)(gap / 1.3);
            } while (changed || gap > 1);
        }
    }
}
