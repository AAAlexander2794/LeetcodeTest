using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_2894
    {
        public class Solution
        {
            public int DifferenceOfSums(int n, int m)
            {
                int num1 = 0;
                int num2 = 0;
                
                for (int i = 1; i <= n; i++)
                {
                    if (i%m == 0) { num2 += i; }
                    else { num1 += i; }
                }
                return num1 - num2;
            }
        }
    }
}
