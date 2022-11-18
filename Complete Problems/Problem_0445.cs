using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Not_Complete_Problems
{
    internal class Problem_0445
    {
        public class Solution
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

            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                string str1 = $"{l1.val}";
                string str2 = $"{l2.val}";

                int count = 0;
                while (l1.next != null)
                {

                    count++;
                    l1 = l1.next;
                    str1 += $"{l1.val}";
                }
                count = 0;
                while (l2.next != null)
                {

                    count++;
                    l2 = l2.next;
                    str2 += $"{l2.val}";
                }
                Console.WriteLine(str1);
                Console.WriteLine(str2);
                
                var result = BigInteger.Parse(str1) + BigInteger.Parse(str2);
                Console.WriteLine(result);
                ListNode node = new ListNode();
                var resultNode = node;

                var str = result.ToString();
                //str = str.Reverse().ToString();

                resultNode.val = int.Parse(str[0].ToString());
                Console.Write($"{int.Parse(str[0].ToString())} ");
                for (int i = 1; i < str.Length; i++)
                {
                    Console.Write($"{int.Parse(str[i].ToString())} ");
                    node.next = new ListNode(int.Parse(str[i].ToString()));
                    node = node.next;

                }

                return resultNode;
            }
        }
    }
}
