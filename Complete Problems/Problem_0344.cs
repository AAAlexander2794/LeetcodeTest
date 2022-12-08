using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0344
    {
        public class Solution
        {
            public void ReverseString(char[] s)
            {
                int half;
                if (s.Length % 2 == 0) half = s.Length / 2;
                else half = (s.Length - 1) / 2;
                for (int i = 0; i < half; i++)
                {
                    var a = s[i];
                    s[i] = s[s.Length - 1 - i];
                    s[s.Length - 1 - i] = a;
                }
            }
        }
    }
}
