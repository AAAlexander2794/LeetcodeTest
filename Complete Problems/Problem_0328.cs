using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_0328
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
            public ListNode OddEvenList(ListNode head)
            {
                if (head == null) return null;

                List<int> list = new List<int>();
                list.Add(head.val);
                while (head.next != null)
                {
                    head = head.next;
                    list.Add(head.val);
                }


                int endOffset;
                if (list.Count % 2 == 0) endOffset = 1;
                else endOffset = 0;

                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 1 + i; j < list.Count - 1 - i - endOffset; j+=2)
                    {
                        int a = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = a;
                    }
                }

                head = new ListNode(list[0]);
                if (list.Count < 2) return head;
                ListNode node = new ListNode(list[1]);
                head.next = node;
                for (int i = 2; i < list.Count; i++)
                {
                    node.next = new ListNode(list[i]);
                    node = node.next;
                }

                //var copy = head;
                //while (true)
                //{
                //    Console.Write($"{copy.val} ");
                //    if (copy.next == null) break;
                //    copy = copy.next;
                //}

                return head;
            }
        }
    }
}
