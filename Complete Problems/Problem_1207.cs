using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_1207
    {
        public class Solution
        {
            public bool UniqueOccurrences(int[] arr)
            {
                int[] counts = new int[2001];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= 0) counts[arr[i]]++;
                    else counts[1000 - arr[i]]++;
                }
                
                var list = counts.Where(x => x != 0).ToList();
                list.Sort();
                for (int i = 1; i < list.Count; i++)
                {
                 if (list[i] == list[i-1])   return false;
                }
                return true;
            }
        }
    }
}
