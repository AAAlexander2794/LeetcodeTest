using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Quest_Math.Level_2
{
    /// <summary>
    /// Q2. Smallest Integer Divisible by K
    /// </summary>
    internal class Q2
    {
        public class Solution
        {
            public int SmallestRepunitDivByK(int k)
            {
                // Четное никогда не будет нацело делить нечетное
                if (k % 2 == 0 || k % 5 == 0) { return -1; }
                //
                int n = 0;
                //
                for (int i = 1; i <= 2147483647; i++)
                {
                    // Потому что 111 % k == ((11 % k) * 10 + 1) % k. Да, вот так.
                    n = (n * 10 + 1) % k;
                    if (n == 0) { return i; }
                }
                //
                return -1;
            }
        }
    }
}
