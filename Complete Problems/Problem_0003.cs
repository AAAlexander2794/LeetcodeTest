using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_0003
    {
        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {
                if (s == null || s.Length == 0) return 0;
                if (s.Length == 1) return 1;
                
                int max = 1;
                int start = 0;
                int end = 0;
                

                while (end < s.Length - 1)
                {
                   
                    for (int i = start; i <= end; i++)
                    {
                        if (s[i] == s[end + 1])
                        {
                            start = i + 1;
                        }
                    }
                    end++;
                    if (end - start + 1 > max) max++;
                }
                return max;
            }
        }
    }
}
