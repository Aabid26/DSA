// See https://aka.ms/new-console-template for more information
using DSA.Sorting;

Console.WriteLine("Program Started....\n");
Console.WriteLine("Before Sorting\n");
List<int> list = new List<int>() { 3, 2, 1, 5, 4 };
foreach (int i in list)
{
    Console.Write(i+"\t");
}

//var sortedList =BubbleSorting.Instance.sort(list);
var sortedList =SelectionSorting.Instance.sort(list);


Console.WriteLine("\nAfter Sorting\n");
foreach (int i in sortedList)
{
    Console.Write(i+"\t");
}
Console.WriteLine("\nProgram Closed....");


