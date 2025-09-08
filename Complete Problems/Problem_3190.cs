using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3190
    {
        public class Solution
        {
            public int MinimumOperations(int[] nums)
            {
                int numberOfOperations = 0;
                foreach (int i in nums)
                {
                    if (i % 3 != 0) { numberOfOperations++; }
                }
                return numberOfOperations;
            }
        }
    }
}
