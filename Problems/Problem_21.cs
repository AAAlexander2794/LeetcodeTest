using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Problems
{

    
  //Definition for singly-linked list.
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

    public partial class Solution
    {
        public void Example()
        {
            var list1 = new ListNode(1);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(4);
            //
            var list2 = new ListNode(1);
            list2.next = new ListNode(3);
            list2.next.next = new ListNode(4);
            //
            var result = MergeTwoLists(list1 , list2);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Done
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Тупые проверки
            if (list1 == null && list2 == null) return null;
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            //
            var list = new List<int>();
            var curList = list1;
            //
            while (true)
            {
                list.Add(curList.val);
                // Берем следующий
                if (curList.next != null) curList = curList.next;
                else break;
            }
            curList = list2;
            while (true)
            {
                list.Add(curList.val);
                // Берем следующий
                if (curList.next != null) curList = curList.next;
                else break;
            }
            //
            list.Sort();
            // Это начало цепочки, нам его вернуть надо
            var result = new ListNode(list[0]);
            if (list.Count < 2) return result;
            // Эту ссылку меняем
            ListNode cur1;
            cur1 = new ListNode(list[1]);
            result.next = cur1;
            //
            int i = 2;
            while (true)
            {
                if (i == list.Count) break;
                var cur2 = new ListNode(list[i]);
                // Передали ссылку
                cur1.next = cur2;
                // Поменяли ссылку
                cur1 = cur2;
                //
                i++;                
            }
            //
            return result;
        }
    }
}
