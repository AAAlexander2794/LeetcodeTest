using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Problems
{
    internal class Problem_0264
    {
        public class Solution
        {
            public int NthUglyNumber(int n)
            {
                var q = new Problem_0263.Solution();
                List<int> list = new List<int>();
                list.Add(1);
                int i = 0;
                //int count = 1;
                while (i < n)
                {

                    list.Add(list[i] * 2);
                    list.Add(list[i] * 3);
                    list.Add(list[i] * 5);
                    list = list.Distinct().ToList();


                    i++;
                    //count = list.Count;
                }
                Console.WriteLine(i);
                list.Sort();
                Console.WriteLine(list[i]);
                list.RemoveRange(n, list.Count - n);
                foreach (var item in list)
                {

                    //Console.Write($"{item} ");
                    if (q.IsUgly(item)) Console.Write($"{item} ");
                }
                Console.WriteLine($"\nNum of numbers: {list.Count}");
                return list[1351];

            }

        }
    }
}
