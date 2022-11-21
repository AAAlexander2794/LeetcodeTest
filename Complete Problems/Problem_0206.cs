using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0206
    {
   
 //* Definition for singly-linked list.
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
            public ListNode ReverseList(ListNode head)
            {
                if (head == null) return null;
                List<int> list = new List<int>();
                list.Add(head.val);
                while (head.next != null)
                {
                    head = head.next;
                    list.Add(head.val);
                }   
                ListNode node = new ListNode(list[list.Count - 1]);
                if (list.Count == 1) return node;
                head = node;
                for (int i = list.Count - 2; i >= 0; i--)
                {
                    head.next = new ListNode(list[i]);
                    head = head.next;
                }
                return node;
            }
        }
    }
}
