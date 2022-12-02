using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_1512
    {
        public class Solution
        {
            public int NumIdenticalPairs(int[] nums)
            {
                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j]) count++;
                    }
                }
                return count;
            }
        }
    }
}
