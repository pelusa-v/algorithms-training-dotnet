using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algorithms_training_dotnet.console.Problems
{
    public class LinealSearch
    {
        public static int? Search(int[] array, int v)
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
    }
}