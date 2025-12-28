using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3074
    {
        public class Solution
        {
            public int MinimumBoxes(int[] apple, int[] capacity)
            {
                Array.Sort(capacity);
                int sum = 0;
                foreach (int i in apple)
                {
                    sum += i;
                }
                for (int i = capacity.Length - 1; i >= 0; i--)
                {
                    sum -= capacity[i];
                    if (sum <= 0)
                    {
                        return capacity.Length - i;
                    }
                }
                return capacity.Length;
            }
        }
    }
}
