namespace algorithms_training_dotnet.console.Utils;

public class ArrayUtils
{
    public static void ShowArrayContent(int[] array)
    {
        Console.Write("[");
        foreach (var item in array)
        {
            Console.Write($"{item}, ");
        }
        Console.Write("]\n");
    }
}
