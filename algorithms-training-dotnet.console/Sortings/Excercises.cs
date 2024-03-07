namespace algorithms_training_dotnet.console.Sortings;

public class Excercises
{
    public static int? LinealSearch(int[] array, int v)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == v)
            {
                return i;
            }
        }

        return null;
    }

    public static int[] BinaryAddition(int[] a, int[] b, int n)
    {
        int offset = 0;
        int[] c = new int[n+1];

        for (int i = n-1; i >= 0; i--)
        {
            c[i+1] = a[i] ^ b[i] ^ offset;
            offset = (a[i] & b[i]) | offset;
        }

        c[0] = offset;
        return c;
    }
}
