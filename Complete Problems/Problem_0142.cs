using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0142
    {
        
 // Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) {
          val = x;
          next = null;
      }
  }
 
        public class Solution
        {
            public ListNode DetectCycle(ListNode head)
            {
                if (head == null) return null;
                List<ListNode> list = new List<ListNode>();
                list.Add(head);
                while (head.next != null)
                {
                    if (list.Contains(head.next)) return head.next;
                    list.Add(head.next);
                    head = head.next;
                }
                return null;
            }
        }
    }
}
