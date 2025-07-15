using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_495
    {
        public class Solution
        {
            public int FindPoisonedDuration(int[] timeSeries, int duration)
            {
                int sum = 0;
                for (int i = 0; i < timeSeries.Length; i++)
                {
                    
                    if (i + 1 < timeSeries.Length)
                    {
                        int diff = timeSeries[i + 1] - timeSeries[i];
                        if (diff < duration)
                        {
                            sum += diff;
                            continue;
                        }
                    }
                    sum += duration;
                }
                return sum;
            }
        }
    }
}
