using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_1480
    {
        public class Solution
        {
            public int[] RunningSum(int[] nums)
            {
                int[] sum = new int[nums.Length];
                for (int i = 0; i < sum.Length; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        sum[i] += nums[j];
                    }
                }
                return sum;
            }
        }
    }
}
