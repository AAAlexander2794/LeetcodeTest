using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0234
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
            public bool IsPalindrome(ListNode head)
            {
                List<int> list = new List<int>();
                list.Add(head.val);
                while(head.next != null)
                {
                    head = head.next;
                    list.Add(head.val);
                }
                var count = list.Count;
                if (count == 1) return true;
                int halfCount;
                if (count % 2 == 0) halfCount = count / 2;
                else halfCount = (count - 1) / 2;
                for (int i = 0; i < halfCount; i++)
                {
                    if (list[i] != list[count - i - 1]) return false;
                }

                return true;
            }
        }
    }
}
