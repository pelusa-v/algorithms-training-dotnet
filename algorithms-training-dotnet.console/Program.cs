using algorithms_training_dotnet.console.Sortings;
using algorithms_training_dotnet.console.Utils;

var testArray = new int[] { 9, 8, 7, 4, 1, 6, 2 };

ArrayUtils.ShowArrayContent(testArray);
InsertionSort.Sort(testArray);
ArrayUtils.ShowArrayContent(testArray);