using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Contests.Warm_Up_Contest
{
    internal class Problem_0387
    {
        public class Solution
        {
            public int FirstUniqChar(string s)
            {
                int[] ar = new int[26];
                foreach (char c in s)
                {
                    ar[c - 'a']++;
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (ar[s[i] - 'a'] == 1) return i;
                }
                return -1;
            }
        }
    }
}
