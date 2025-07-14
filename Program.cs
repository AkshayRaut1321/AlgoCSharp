using AlgoCSharp.Algorithms;
using AlgoCSharp.Algorithms.ArrayADT;
using AlgoCSharp.Algorithms.LinkedList;
using AlgoCSharp.Algorithms.String;
using AlgoCSharp.LeetCodeProblems;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlgoCSharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Input: ");
            //BinaryTreeExample.Run();

            //var sedolChecker = new SEDOLChecker();
            //sedolChecker.Test();

            //PowerFunction.PowerBruteForce(2, 9);
            //PowerFunction.PowerOptimized(2, 9);

            //Console.WriteLine(TaylorSeries.TaylorMaclaurin(10, 3));
            //var result = TaylorSeries.TaylorMaclaurinMultiReturn(10, 3, 1, 1);
            //Console.WriteLine("Result : " + result.Item1);

            //Console.WriteLine("Result : " + Fibonacci.FibIterative(int.Parse(Console.ReadLine())));
            //Console.WriteLine("Result : " + Fibonacci.FibExcessiveRecursion(int.Parse(Console.ReadLine())));
            //Console.WriteLine("Result : " + Fibonacci.FibOptimizedRecursionUsingMemoization(int.Parse(Console.ReadLine())));

            //Console.WriteLine("Result : " + CombinationPermutation.nCrWithFactorialRecursion(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Console.WriteLine("Result : " + CombinationPermutation.nCrWithPascalTriangeRecursion(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

            //Console.WriteLine("Tower of Hanoi: ");
            //TowerOfHanoi.TOH(2, "A", "B", "C");
            //Console.WriteLine("Result quiz: " + f(1));

            //SortedArrayADT.FindMultipleMissingNumbers(new int[] { 6, 7, 8, 9, 11, 14, 16, 17 });

            //TaskParallelism.ParallelForWithException();
            //TaskParallelism.CombineResultFromTasks();
            //TaskParallelism.ParalleWithCancel();
            //TaskParallelism.TaskWait();

            //RemoveInPlaceElement.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);

            //ArrayADT arrayADT = new ArrayADT();
            //arrayADT.Start();

            //Console.WriteLine("Enter the number to append");
            //int newItem = Convert.ToInt32(Console.ReadLine());
            //arrayADT.Append(newItem);

            //arrayADT.Display();

            //Console.WriteLine("Enter the number to insert");
            //newItem = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the position to insert the number");
            //var insertAt = Convert.ToInt32(Console.ReadLine());

            //arrayADT.Insert(newItem, insertAt);

            //arrayADT.Display();

            //NumberPalindrome numberPalindrome = new NumberPalindrome();
            //Console.WriteLine(numberPalindrome.IsPalindromeReverseOnlyHalf(2112));

            //LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix();
            //Console.WriteLine(longestCommonPrefix.Run("flower", "flow", "flight"));

            //ArrayAlgorithms arrayAlgorithms = new ArrayAlgorithms();
            //Console.WriteLine(arrayAlgorithms.FindSingleElementMissingBy1PlaceInSortedNaturalNumbersUsingFormula(1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12));
            //arrayAlgorithms.FindSingleElementMissingBy1PlaceInSortedNonNaturalNumbers(6, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17);
            //arrayAlgorithms.FindMultipleMissingNumbersInSortedPositiveIntegers(6, 7, 8, 9, 10, 12, 15, 16, 17);
            //arrayAlgorithms.FindMultipleMissingNumbersUnsortedPositiveIntegers(new int[] { 3, 7, 4, 9, 12, 6, 1, 11, 2, 10 });
            //arrayAlgorithms.FindUniqueDuplicatesSortedPositiveIntegers(3, 6, 8, 8, 10, 12, 15, 15, 15, 20);
            //arrayAlgorithms.CountDuplicatesSortedPositiveIntegersHash(3, 6, 8, 8, 10, 12, 15, 15, 15, 20);
            //arrayAlgorithms.CountDuplicatesUnsortedPositiveIntegersHash(3, 6, 8, 8, 10, 12, 15, 15, 15, 20);
            //arrayAlgorithms.CountDuplicatesUnsortedPositiveIntegersHash(8, 3, 6, 4, 6, 5, 6, 8, 2, 7);
            //arrayAlgorithms.FindMinMaxWithoutUsingIntMinMax(5, 8, 3, 9, 6, 2, 10, -1, 4);

            //TwoSumProblem problem = new TwoSumProblem();
            ////var output = problem.TwoSumStoreOriginalNumberSinglePairIndices(new int[] { 3, 3, 4, 2, 4 }, 6);
            ////var output = problem.TwoSumStoreOriginalNumberSinglePair(new int[] { 3, 3, 4, 2, 4 }, 6);
            ////var output = problem.TwoSumStoreComplement(new int[] { 1, 3, 4, 2, 4 }, 6);
            ////var output = problem.TwoSumStoreOriginalNumberReturnMultiplePairIndices(new int[] { 3, 3, 4, 2, 4 }, 6);
            ////foreach (var item in output)
            ////{
            ////    Console.WriteLine($"{item[0]}, {item[1]}");
            ////}
            //var output = problem.TwoSumSortedReturnMultiplePairIndices(new int[] { 1, 3, 4, 5, 6, 8, 9, 10, 12, 14 }, 10);
            //foreach (var item in output)
            //{
            //    Console.WriteLine($"{item[0]}, {item[1]}");
            //}

            //ValidParentheses validParentheses = new ValidParentheses();
            //Console.WriteLine(validParentheses.IsValid("({[])}"));

            //// Creating the first linked list: 1 -> 2 -> 4
            //ListNode list1 = new ListNode(1);
            //list1.next = new ListNode(2);
            //list1.next.next = new ListNode(4);

            //// Creating the second linked list: 1 -> 3 -> 4
            //ListNode list2 = new ListNode(1);
            //list2.next = new ListNode(3);
            //list2.next.next = new ListNode(4);

            //MergeTwoSortedLists mergeTwoSortedLists = new MergeTwoSortedLists();
            //mergeTwoSortedLists.MergeTwoListsByChatGPT(list1, list2);

            //StringPalindrome stringPalindrome = new StringPalindrome();
            ////Console.WriteLine(stringPalindrome.IsPalindromeSimple("ABCCBA"));
            //Console.WriteLine(stringPalindrome.IsPalindromeOnlyAlphaNumeric("A man, a plan, a canal: Panama"));

            //BinarySearch binarySearch = new BinarySearch();
            //var array = new int[] { 4, 8, 13, 18, 21, 24, 29, 34 };
            //Console.WriteLine(binarySearch.RecursiveBinarySearch(array, 0, array.Length, 18));

            //LinkedListProgram linkedListProgram = new LinkedListProgram();

            //var foundNode = linkedListProgram.LinearSearchMoveToFirst(node, 20);
            //Console.WriteLine(foundNode != null ? "Found" : "Not found");
            //linkedListProgram.InsertAt(head, 3, 35);
            //linkedListProgram.InsertLast(10);
            //linkedListProgram.InsertLast(20);
            //linkedListProgram.InsertLast(30);
            //linkedListProgram.InsertLast(40);
            //linkedListProgram.InsertLast(50);
            //linkedListProgram.InsertSorted(45);
            //linkedListProgram.Delete(10);
            //linkedListProgram.Delete(20);
            //linkedListProgram.DeleteByValue(50);

            //linkedListProgram.InsertLast(10);
            //linkedListProgram.InsertLast(20);
            //linkedListProgram.InsertLast(20);
            //linkedListProgram.InsertLast(30);
            //linkedListProgram.InsertLast(30);
            //linkedListProgram.InsertLast(30);
            //linkedListProgram.RemoveDuplicatesFromSorted();
            //linkedListProgram.ReverseByElements();
            //linkedListProgram.ReverseByLinks();
            //linkedListProgram.ReverseUsingTailRecursion(null, linkedListProgram.First);
            //linkedListProgram.ReverseUsingPostOrderRecursion(linkedListProgram.First);

            //linkedListProgram.CauseLoop();
            //var hasLoop = linkedListProgram.HasLoopUsingMemoization();
            //var hasLoop = linkedListProgram.HasLoopUsingSlidingWindow();
            //Console.WriteLine(hasLoop);

            CircularLinkedListProgram cll = new CircularLinkedListProgram();
            //cll.Head = new SinglyLinkedList(10);
            //cll.Head.Next = new SinglyLinkedList(20);
            //cll.Head.Next.Next = new SinglyLinkedList(30);
            //cll.Head.Next.Next.Next = cll.Head;
            cll.InsertAt(0, 10);
            cll.InsertAt(1, 20);
            cll.InsertAt(2, 30);
            cll.InsertAt(3, 40);
            cll.InsertAt(5, 35);
            cll.DisplayUsingLoop(cll.Head);
            //cll.DisplayRecursively(cll.Head);

            //StringNeedleHaystack searchOccurrence = new StringNeedleHaystack();
            //Console.WriteLine(searchOccurrence.FindFirstOccurrenceOfString("abcabcabc", "cab"));
            //Console.WriteLine(searchOccurrence.KMPStringIndexSearch("abcabcabc", "cab"));
            //Console.WriteLine(searchOccurrence.RabinKarpSearch("abcabcabc", "cab"));

            //BestTimeToBuySellStock a = new BestTimeToBuySellStock();
            //var maxProfit = a.MaxProfit(new int[] { 2,4,1 });
            //var maxProfit = a.MaxProfit(new int[] { 10, 9, 5, 4, 1 });
            //var maxProfit = a.MaxProfit(new int[] { 2, 4, 1, 2, 3, 4, 3 });
            //var maxProfit = a.MaxProfit(new int[] { 7, 1, 4, 3, 6, 5 });
            //Console.WriteLine(maxProfit);

            Console.Read();
        }

        static int i = 1;

        static int f(int n)
        {
            if (n >= 5)
                return n;

            n = n + i;
            i++;
            return f(n);
        }
    }
}
