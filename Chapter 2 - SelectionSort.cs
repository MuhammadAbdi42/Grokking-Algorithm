public class Solution
{
    public int[] SelectionSort(int[] array)
    {
        int[] sortedArray = new int[array.Length];
        int[] searchedArray = new int[array.Length];
        for (int i = 0; i < searchedArray.Length; i++)
        {
            searchedArray[i] = 0;
        }

        int temp = array[0], tempIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < searchedArray.Length; j++)
            {
                if (searchedArray[j] == 0)
                {
                    temp = array[j];
                    tempIndex = j;
                    break;
                }
            }
            for (int j = 0; j < array.Length; j++)
            {
                if (searchedArray[j] == 1) continue;
                if (temp > array[j])
                {
                    temp = array[j];
                    tempIndex = j;
                }
            }

            sortedArray[i] = temp;
            searchedArray[tempIndex] = 1;
        }
        return sortedArray;
    }
}