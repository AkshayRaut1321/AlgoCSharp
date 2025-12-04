using AlgoCSharp.Algorithms;
using AlgoCSharp.Algorithms.ArrayADT;
using AlgoCSharp.Algorithms.BinaryTree;
using AlgoCSharp.Algorithms.BinaryTree.BinarySearchTree;
using AlgoCSharp.Algorithms.LinkedList;
using AlgoCSharp.Algorithms.QueueADT;
using AlgoCSharp.Algorithms.StackADT;
using AlgoCSharp.Algorithms.String;
using AlgoCSharp.LeetCodeProblems;
using AlgoCSharp.WarmupProblems;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlgoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //PatternPrinting patternPrinting = new PatternPrinting();
            //patternPrinting.StarPyramidFromCentre(6);

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

            //SinglyLinkedListProgram sllp = new SinglyLinkedListProgram();

            //var foundNode = linkedListProgram.LinearSearchMoveToFirst(node, 20);
            //Console.WriteLine(foundNode != null ? "Found" : "Not found");
            //linkedListProgram.InsertAt(head, 3, 35);
            //sllp.InsertLast(10);
            //sllp.InsertLast(20);
            //sllp.InsertLast(30);
            //sllp.InsertLast(40);
            //sllp.InsertLast(50);
            //sllp.InsertLast(60);
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
            //Console.WriteLine(sllp.GetMiddleNodeTortoiseHare().Value);

            //SinglyLinkedListProgram sllp2 = new SinglyLinkedListProgram();
            //sllp2.First = new SinglyLinkedListNode(20);
            //sllp2.First.Next = new SinglyLinkedListNode(10);
            //sllp2.First.Next.Next = sllp.First.Next.Next.Next;
            ////Console.WriteLine(sllp2.FindIntersectingNodeDictionary(sllp.First).Value);
            ////Console.WriteLine(sllp.FindIntersectingNodeLengthAlignment(sllp.First, sllp2.First).Value);
            //Console.WriteLine(sllp.FindIntersectingNodeTortoiseSwitchPath(sllp.First, sllp2.First).Value);

            //CircularLinkedListProgram cll = new CircularLinkedListProgram();
            //cll.Head = new SinglyLinkedList(10);
            //cll.Head.Next = new SinglyLinkedList(20);
            //cll.Head.Next.Next = new SinglyLinkedList(30);
            //cll.Head.Next.Next.Next = cll.Head;
            //cll.InsertAt(0, 10);
            //cll.InsertAt(1, 20);
            //cll.InsertAt(2, 30);
            //cll.InsertAt(3, 40);
            //cll.InsertAt(3, 35);
            //cll.DisplayUsingLoop(cll.Head);
            //cll.DisplayRecursively(cll.Head);
            //cll.DeleteAt(5);
            //Console.WriteLine("After deleting");
            //cll.DisplayUsingLoop(cll.Head);

            //DoublyLinkedListProgram dllp = new DoublyLinkedListProgram();
            //dllp.First = new DoublyLinkedListNode(10);
            //dllp.First.Next = new DoublyLinkedListNode(20);
            //dllp.First.Next.Previous = dllp.First;
            //dllp.First.Next.Next = new DoublyLinkedListNode(30);
            //dllp.First.Next.Next.Previous = dllp.First.Next;
            //dllp.First.Next.Next.Next = new DoublyLinkedListNode(40);
            //dllp.First.Next.Next.Next.Previous = dllp.First.Next.Next;
            //dllp.First.Next.Next.Next.Next = new DoublyLinkedListNode(50);
            //dllp.First.Next.Next.Next.Next.Previous = dllp.First.Next.Next.Next;
            //dllp.Count = 5;
            //dllp.InsertAt(0, 5);
            //dllp.InsertAt(2, 15);
            //dllp.InsertAt(6, 45);
            //dllp.Display();
            //dllp.DeleteAt(3);
            //dllp.Display();
            //dllp.Reverse();
            //dllp.Display();

            //CircularDoublyLinkedListProgram cdllp = new CircularDoublyLinkedListProgram();
            //cdllp.Head = new CircularDoublyLinkedList(10);
            //cdllp.Head.Next = new CircularDoublyLinkedList(20);
            //cdllp.Head.Next.Previous = cdllp.Head;
            //cdllp.Head.Next.Next = new CircularDoublyLinkedList(30);
            //cdllp.Head.Next.Next.Previous = cdllp.Head.Next;
            //cdllp.Head.Next.Next.Next = new CircularDoublyLinkedList(40);
            //cdllp.Head.Next.Next.Next.Previous = cdllp.Head.Next.Next;
            //cdllp.Head.Next.Next.Next.Next = new CircularDoublyLinkedList(50);
            //cdllp.Head.Next.Next.Next.Next.Previous = cdllp.Head.Next.Next.Next;
            //cdllp.Head.Next.Next.Next.Next.Next = cdllp.Head;
            //cdllp.Head.Previous = cdllp.Head.Next.Next.Next.Next;
            //cdllp.Count = 5;
            //cdllp.Display();
            //cdllp.InsertAt(4, 45);
            //cdllp.Display();
            //cdllp.DeleteAt(3);
            //cdllp.Display();

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

            //StackArrayADT<int> intStack = new StackArrayADT<int>(5);
            //intStack.Push(10);
            //intStack.Push(20);
            //intStack.Push(30);
            //intStack.Push(50);
            //intStack.Push(60);
            //try
            //{
            //    intStack.Push(70);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("All values:");
            //intStack.Display();
            //var popElement = intStack.Pop();
            //Console.WriteLine($"Pop: {popElement}");
            //Console.WriteLine("All values:");
            //intStack.Display();
            //var peekElement = intStack.PeekAt(2);
            //Console.WriteLine($"Peek: {peekElement}");
            //intStack.Pop();
            //intStack.Pop();
            //intStack.Pop();
            //intStack.Pop();
            //try
            //{
            //    intStack.Pop();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //StackLinkedListADT linkedlistStack = new StackLinkedListADT(5);
            //linkedlistStack.Push(10);
            //linkedlistStack.Push(20);
            //linkedlistStack.Push(30);
            //linkedlistStack.Push(50);
            //Console.WriteLine("All values:");
            //linkedlistStack.Display();
            //var popLLNElement = linkedlistStack.Pop();
            //Console.WriteLine($"Pop: {popLLNElement}");
            //Console.WriteLine("All values:");
            //linkedlistStack.Display();
            //var peekLLNElement = linkedlistStack.PeekAt(2);
            //Console.WriteLine($"Peek: {peekLLNElement}");

            //ValidParenthesesOnlyRound validParenthesesOnlyRound = new ValidParenthesesOnlyRound();
            //Console.WriteLine(validParenthesesOnlyRound.IsValid("(a+)b(c+d)"));

            //InfixPostfixConversion infixPostfixConversion = new InfixPostfixConversion();
            //Console.WriteLine(infixPostfixConversion.ConvertOptimized("a+b*c-d/e"));
            //Console.WriteLine(infixPostfixConversion.ConvertForParenthesized("(a+b)*c-d^e^f"));
            //var postFix = infixPostfixConversion.ConvertForParenthesized("3*5+6/2-4");
            //Console.WriteLine(postFix);
            //Console.WriteLine(infixPostfixConversion.EvaluateParenthesizedExpression(postFix));

            //LinearQueueArrayADT<int> linearQueue = new LinearQueueArrayADT<int>(5);
            //linearQueue.Enqueue(1);
            //linearQueue.Enqueue(2);
            //linearQueue.Enqueue(3);
            //linearQueue.Display();
            //linearQueue.Dequeue();
            //linearQueue.Dequeue();
            //linearQueue.Dequeue();
            //linearQueue.Enqueue(1);
            //linearQueue.Display();
            //CircularQueueArrayADT<int> circularQueue = new CircularQueueArrayADT<int>(2);
            //circularQueue.Enqueue(10);
            //circularQueue.Enqueue(20);
            //circularQueue.Display();
            //circularQueue.Dequeue();
            //circularQueue.Enqueue(30);
            //circularQueue.Display();
            //DequeueArrayNonCircularADT<int> dequeue = new DequeueArrayNonCircularADT<int>(3);
            //dequeue.EnqueueAtRear(10);
            //dequeue.EnqueueAtRear(20);
            //dequeue.EnqueueAtRear(30);
            //dequeue.Display();
            //dequeue.DequeueAtRear();
            //dequeue.DequeueAtFront();
            //dequeue.DequeueAtRear();
            //dequeue.DequeueAtFront();
            //dequeue.Display();

            //PriorityQueueBucketArrayADT priorityQueue = new PriorityQueueBucketArrayADT(3, 3);
            //priorityQueue.Enqueue(100, 0);
            //priorityQueue.Enqueue(10, 1);
            //priorityQueue.Enqueue(1, 2);
            //priorityQueue.Dequeue();
            //priorityQueue.Dequeue();
            //priorityQueue.Dequeue();

            //BinaryTree example = new BinaryTree();
            //var binaryTreeRoot = example.Create();

            //Console.WriteLine("Displaying binary tree in pre-order recursively");
            //example.DisplayPreOrderRecursive(binaryTreeRoot);
            //Console.WriteLine("Displaying binary tree in in-order recursively");
            //example.DisplayInOrderRecursive(binaryTreeRoot);
            //Console.WriteLine("Displaying binary tree in post-order recursively");
            //example.DisplayPostOrderRecursive(binaryTreeRoot);
            //Console.WriteLine("Displaying binary tree in pre-order iteratively");
            //example.DisplayPreOrderIterative(binaryTreeRoot);
            //Console.WriteLine("Displaying binary tree in in-order iteratively");
            //example.DisplayInOrderIterative(binaryTreeRoot);
            //Console.WriteLine("Displaying binary tree in post-order iteratively");
            //example.DisplayPostOrderIterative(binaryTreeRoot);
            //Console.WriteLine("Displaying binary tree in level-order iteratively");
            //example.DisplayLevelOrderIterative(binaryTreeRoot);
            //Console.WriteLine("Displaying count, sum, countDeg2, height, leaf nodes, non-leaf nodes of binary tree");
            //Console.WriteLine(example.Count(binaryTreeRoot));
            //Console.WriteLine(example.Sum(binaryTreeRoot));
            //Console.WriteLine(example.CountParentOnlyForDegree2(binaryTreeRoot));
            //Console.WriteLine(example.CalculateHeight(binaryTreeRoot));
            //Console.WriteLine(example.CountLeafNodes(binaryTreeRoot));
            //Console.WriteLine(example.CountNonLeafNodes(binaryTreeRoot));

            BinarySearchLinked binarySearchLinked = new BinarySearchLinked();
            //var result = binarySearchLinked.IterativeSearch(binaryTreeRoot, 45);
            //Console.WriteLine($"IterativeSearch: {result?.Data}");
            //var result2 = binarySearchLinked.RecursiveSearch(binaryTreeRoot, 55);
            //Console.WriteLine($"RecursiveSearch: {result2?.Data}");
            //binarySearchLinked.InsertWithIterativeSearch(30);
            //binarySearchLinked.InsertWithIterativeSearch(20);
            //binarySearchLinked.InsertWithIterativeSearch(40);
            //binarySearchLinked.InsertWithIterativeSearch(10);
            //binarySearchLinked.InsertWithIterativeSearch(25);
            //binarySearchLinked.InsertWithIterativeSearch(35);
            //var newTreeRoot = binarySearchLinked.InsertWithIterativeSearch(50);

            var node = binarySearchLinked.InsertWithRecursiveSearch(null, 30);
            binarySearchLinked.InsertWithRecursiveSearch(node, 20);
            binarySearchLinked.InsertWithRecursiveSearch(node, 40);
            binarySearchLinked.InsertWithRecursiveSearch(node, 10);
            binarySearchLinked.InsertWithRecursiveSearch(node, 25);
            binarySearchLinked.InsertWithRecursiveSearch(node, 35);
            binarySearchLinked.InsertWithRecursiveSearch(node, 50);
            Console.WriteLine($"Inserted");

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