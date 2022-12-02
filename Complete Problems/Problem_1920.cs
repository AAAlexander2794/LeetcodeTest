using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_1920
    {
        public class Solution
        {
            public int[] BuildArray(int[] nums)
            {
                int[] ans = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    ans[i] = nums[nums[i]];
                }
                return ans;
            }
        }
    }
}
