namespace algorithms_training_dotnet.console.Sortings;

public class InsertionSort
{
    public static void Sort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            var toCompare = array[i];
            var j = i - 1;

            while (j >= 0 && array[j] > toCompare)
            {
                array[j+1] = array[j];
                j--;
            }
            array[j+1] = toCompare;
        }
    }
}
