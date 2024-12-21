public class Solution
{
    public int BinarySearchForStrings(List<string> sortedList, string target)
    {
        int low = 0, high = sortedList.Count - 1, mid = (high + low) / 2;
        while (low <= high)
        {
            if (target == sortedList[mid]) return mid;
            for (int letterIndicator = 0; ; letterIndicator++)
            {
                if (letterIndicator == target.Length)
                {
                    high = mid - 1;
                    mid = (high + low) / 2;
                    break;
                }
                if (letterIndicator == sortedList[mid].Length)
                {
                    low = mid + 1;
                    mid = (high + low) / 2;
                    break;
                }
                if (target[letterIndicator] > sortedList[mid][letterIndicator])
                {
                    low = mid + 1;
                    mid = (high + low) / 2;
                    break;
                }
                if (target[letterIndicator] < sortedList[mid][letterIndicator])
                {
                    high = mid - 1;
                    mid = (high + low) / 2;
                    break;
                }
            }
        }
        return -1;
    }
}