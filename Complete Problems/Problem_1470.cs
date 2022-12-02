using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_1470
    {
        public class Solution
        {
            public int[] Shuffle(int[] nums, int n)
            {
                int[] result = new int[nums.Length];
                int i = 0;
                //int j = 0;

                while (i < n)
                {
                    result[1 + 2 * i] = nums[n + i];
                    result[2 * i] = nums[i];
                    i++;
                }
                return result;
            }
        }
    }
}
