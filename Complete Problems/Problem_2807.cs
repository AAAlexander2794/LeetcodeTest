using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_2807
    {

        // Definition for singly-linked list.
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

        public class Solution
        {
            public ListNode InsertGreatestCommonDivisors(ListNode head)
            {
                var current = head;
                while (current.next != null)
                {
                    var nextNode = current.next;
                    ListNode newNode = new ListNode(GetGreatestCommonDivisor(current.val, nextNode.val), nextNode);
                    current.next = newNode;
                    current = nextNode;
                }
                return head;
            }

            private int GetGreatestCommonDivisor(int a, int b)
            {
                for (int i = Math.Min(a, b); i > 1; i--)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        return i;
                    }
                }
                return 1;
            }
        }
    }
}
