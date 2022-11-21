using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Not_Complete_Problems
{
    internal class Problem_0876
    {
        
  //Definition for singly-linked list.
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
            public ListNode MiddleNode(ListNode head)
            {
                ListNode node = head;
                int count = 1;
                while (node.next != null)
                {
                    node = node.next;
                    count++;
                }
                Console.Write(count + " ");
                if (count % 2 == 0) count = count / 2 + 1;
                else count = (count - 1) / 2 + 1;
                Console.WriteLine(count);
                node = head;
                for (int i = 0; i < count - 1; i++)
                {
                    node = node.next;
                }
                return node;
            }
        }
    }
}
