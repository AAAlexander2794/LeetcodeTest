using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0121
    {
        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                int max = 0;
                int min = prices[0];
                for (int i = 0; i < prices.Length; i++)
                {
                    if (prices[i] < min) min = prices[i];
                    else if (prices[i] - min > max) max = prices[i] - min;
                }
                return max;
            }
        }
    }
}
