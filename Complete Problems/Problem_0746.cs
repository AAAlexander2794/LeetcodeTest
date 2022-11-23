using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0746
    {
        public class Solution
        {
            public int MinCostClimbingStairs(int[] cost)
            {
                int[] sum = new int[cost.Length];
                sum[0] = cost[0];
                sum[1] = cost[1];
                for (int i = 2; i < cost.Length; i++)
                {
                    sum[i] = cost[i] + Math.Min(sum[i-1], sum[i-2]);
                }
                
                return Math.Min(sum[cost.Length - 1], sum[cost.Length - 2]);
            }
        }
    }
}
