// See https://aka.ms/new-console-template for more information
using DSA.Comoon_Coding_Question.Array_Operations;
using DSA.Comoon_Coding_Question.String_Manipulation;
using DSA.Sorting;

Console.WriteLine("Program Started....\n");
#region Code_Practise

    #region String_Manipulation
//        string input = "Aabid";
//        string input1 = "Madam";
//        string input2 = "121";
//        string input3 = "geekSskeeg";
//        Console.WriteLine("Input String: "+input);
//        //string output = StringReverse.ProcessReverse(input);
//        //Console.WriteLine($" Is { input3} Palindrome? : {IsPalindrome.Check(input3)} ");
//        Console.WriteLine($"The occurance of m in {input1} : {Character_Occurance.Count(input1, 'm')} ");
//        //Console.WriteLine("Output String: "+output);
#endregion

#region Array_Operations
int[] arr = { 1, 2, 3, 4, 5 };
int[] arr2 = { };
int[] arr3 = { 49};
int[] arr4 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
Console.WriteLine($"Input Array: {String.Join(",",arr4)} \n");

Console.WriteLine($"SubArray with Maximum sum is : {String.Join(",", SubArray.WithMaximumSum(arr4))}");
//Console.WriteLine($"\nMamimum number present : {Maximum_Element.Find(arr)}");
//Console.WriteLine($"\nOutput Array:\n");
//int[] output = ArrayReverse.Reverse(arr3);
//foreach (int i in output)
//{
//    Console.Write(i + "\t");
//}

#endregion

#endregion

#region Sorting Algorithm

//Console.WriteLine("Before Sorting\n");
//List<int> list = new List<int>() { 3, 2, 1, 5, 4 };
//foreach (int i in list)
//{
//    Console.Write(i+"\t");
//}

////var sortedList =BubbleSorting.Instance.sort(list);
////var sortedList =SelectionSorting.Instance.sort(list);
////var sortedList = InsertionSorting.Instance.sort(list);
////var sortedList = QuickSorting.Instance.sort(list);
//var sortedList = MergeSorting.Instance.sort(list);


//Console.WriteLine("\nAfter Sorting\n");
//foreach (int i in sortedList)
//{
//    Console.Write(i+"\t");
//}

#endregion
Console.WriteLine("\nProgram Closed....");


