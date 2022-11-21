using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0409
    {
        public class Solution
        {
            public int LongestPalindrome(string s)
            {
                List<char> chars = new List<char>();
                int res = 0;
                foreach (char c in s)
                {
                    if (chars.Contains(c))
                    {
                        res += 2;
                        chars.Remove(c);
                    }
                    else chars.Add(c);
                }
                if (chars.Count > 0) res++;
                return res;
            }
        }
    }
}
