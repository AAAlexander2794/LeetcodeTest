using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3794
    {
        public class Solution
        {
            public string ReversePrefix(string s, int k)
            {
                char[] chars = s.ToCharArray();
                int left = 0;
                k--;
                while (left < k)
                {
                    char c = chars[left];
                    chars[left] = chars[k];
                    chars[k] = c;
                    left++;
                    k--;
                }
                return new string(chars);
            }
        }
    }
}
