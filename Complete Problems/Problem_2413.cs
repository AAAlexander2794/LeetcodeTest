using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_2413
    {
        public class Solution
        {
            public int SmallestEvenMultiple(int n)
            {
                if (n % 2 == 0) return n;
                else return n * 2;
            }
        }
    }
}
