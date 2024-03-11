namespace algorithms_training_dotnet.console.Problems;

public class BinaryAddition
{
    public static int[] Add(int[] a, int[] b, int n)
    {
        int offset = 0;
        int[] c = new int[n+1];

        for (int i = n-1; i >= 0; i--)
        {
            c[i+1] = a[i] ^ b[i] ^ offset;
            offset = (a[i] & b[i]) | (a[i] & offset) | (b[i] & offset);
        }

        c[0] = offset;
        return c;
    }
}
