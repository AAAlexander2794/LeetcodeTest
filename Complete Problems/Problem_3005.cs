using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3005
    {
        public class Solution
        {
            public int MaxFrequencyElements(int[] nums)
            {
                int[] freqs = new int[100];
                int max = 0;
                int count = 0;
                foreach (int i in nums)
                {
                    freqs[i - 1]++;
                }
                foreach (int i in freqs)
                {
                    if (i == max)
                    {
                        count++;
                    }
                    if (i > max)
                    {
                        max = i;
                        count = 1;
                    }
                }
                return max * count;
            }
        }
    }
}
