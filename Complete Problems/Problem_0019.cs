using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_0019
    {
        
 // Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
        public class Solution
        {
            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                List<int> list = new List<int>();
                list.Add(head.val);
                while (head.next != null)
                {
                    head = head.next;
                    list.Add(head.val);
                }
                list.RemoveAt(list.Count - n);
                Console.WriteLine(list.Count);
                if (list.Count == 0) return null;
                head = new ListNode(list[0]);
                var node = head;
                if (list.Count == 1) return head;
                for (int i = 1; i < list.Count; i++)
                {
                    node.next = new ListNode(list[i]);
                    node = node.next;
                }
                return head;
            }
        }
    }
}
