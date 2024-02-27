using algorithms_training_dotnet.console.Utils;

namespace algorithms_training_dotnet.console.Sortings;

public class InsertionSort
{
    // public static int[] Sort(int[] disordered)
    // {
    //     int[] sorted = [];

    //     for (int i = 0; i < disordered.Length; i++)
    //     {
    //         sorted = [.. sorted, disordered[i]];
    //         var end = sorted.Length;

    //         Console.WriteLine("------");
    //         ArrayUtils.ShowArrayContent(sorted);

    //         if(end >= 2)
    //         {
    //             while (sorted[end-2] >= sorted[end-1])
    //             {
    //                 var aux = sorted[end-2];
    //                 sorted[end-2] = sorted[end-1];
    //                 sorted[end-1] = aux;
    //                 end--;

    //                 if (end < 2) break;
    //             }
    //         }
    //         Console.WriteLine("Sorting...");
    //         ArrayUtils.ShowArrayContent(sorted);
    //     }
    //     return sorted;
    // }

    public static void Sort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            var k = i;
            var current = array[k];
            while (array[k - 1] > current)
            {
                var temp = array[k - 1];
                array[k - 1] = current;
                array[k] = temp;
                k--;

                if (k == 0) break;
            }
        }
    }
}
