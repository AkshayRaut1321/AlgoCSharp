using System;
using System.Collections.Generic;

namespace AlgoCSharp.LeetCodeProblems
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoListsByChatGPT(ListNode list1, ListNode list2)
        {
            // Create a dummy node to act as the starting point
            ListNode dummy = new ListNode(-1);
            ListNode current = dummy;

            // Traverse through both lists until one is exhausted
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;  // Move the current pointer to the next node
            }

            // If one list is not exhausted, append the remaining nodes
            if (list1 != null)
            {
                current.next = list1;
            }
            else
            {
                current.next = list2;
            }

            return dummy.next;  // Return the head of the merged list
        }

        public void MergeTwoListsByAkshay(ListNode list1, ListNode list2)
        {
            List<ListNode> nodes = new List<ListNode>();
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    nodes.Add(list1);
                    list1 = list1.next;
                }
                else
                {
                    nodes.Add(list2);
                    list2 = list2.next;
                }
            }

            while (list1 != null)
            {
                nodes.Add(list1);
                list1 = list1.next;
            }

            while (list2 != null)
            {
                nodes.Add(list2);
                list2 = list2.next;
            }

            ListNode final = null;
            if (nodes.Count > 0)
            {
                final = nodes[0];
                for (int i = 0; i < nodes.Count - 1; i++)
                {
                    nodes[i].next = nodes[i + 1];
                }
            }

            //return final;

            PrintList(final);
        }

        public void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }
    }
}
