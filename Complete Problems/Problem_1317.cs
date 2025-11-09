using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_1317
    {
        public class Solution
        {
            public int[] GetNoZeroIntegers(int n)
            {
                int a = 0;
                int b = n;
                while (a.ToString().Contains("0") || b.ToString().Contains("0"))
                {
                    a++;
                    b--;
                }
                return [a, b];
            }
        }
    }
}
