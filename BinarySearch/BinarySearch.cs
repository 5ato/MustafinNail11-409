namespace BinarySearch;

public class BinarySearch
{
    public static int Solution(int[] array, int target)
    {
        int left = 0, right = array.Length - 1, middle;
        while (left <= right)
        {
            middle = (left + right) / 2;
            if (array[middle] == target)
                return middle;
            else if (array[middle] < target)
                left = middle + 1;
            else if (array[middle] > target)
                right = middle - 1;
        }
        return -1;
    }
}
