using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_2181
    {

        //* Definition for singly-linked list.
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
            public ListNode MergeNodes(ListNode head)
            {
                ListNode startEmpty = new ListNode();
                ListNode node = startEmpty;
                int sum = 0;
                while (head != null)
                {
                    if (head.val == 0)
                    {
                        node.next = new ListNode(sum);
                        node = node.next;
                        sum = 0;
                    }
                    else
                    {
                        sum += head.val;
                    }
                    head = head.next;
                }
                return startEmpty.next.next;
            }
        }
    }
}
