using algorithms_training_dotnet.console.Problems;
using algorithms_training_dotnet.console.Sortings;
using algorithms_training_dotnet.console.Utils;

// insertion sort
var testArray = new int[] { 9, 8, 7, 4, 1, 6, 2, 9 };
ArrayUtils.ShowArrayContent(testArray);
InsertionSort.Sort(testArray);
ArrayUtils.ShowArrayContent(testArray);

// lineal search
var testArray2 = new int[] { 9, 8, 7, 4, 1, 6, 2, 9 };
var i = LinealSearch.Search(testArray2, 2);
Console.WriteLine(i);

// binary addition
var a1 = new int[] { 0, 1 };  // 3
var b1 = new int[] { 0, 1 };  // 1
var c = BinaryAddition.Add(a1, b1, a1.Length);
ArrayUtils.ShowArrayContent(c);

// binary addition
var a2 = new int[] { 1, 1, 1, 1, 1, 1, 1, 1 };
var b2 = new int[] { 1, 1, 1, 1, 1, 1, 1, 1 };
var c2 = BinaryAddition.Add(a2, b2, a2.Length);
ArrayUtils.ShowArrayContent(c2);

// binary addition
var a3 = new int[] { 1, 0, 1, 0, 1 };
var b3 = new int[] { 1, 1, 0, 1, 0 };
var c3 = BinaryAddition.Add(a3, b3, b3.Length);
ArrayUtils.ShowArrayContent(c3);
