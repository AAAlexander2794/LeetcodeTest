using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_1929
    {
        public class Solution
        {
            public int[] GetConcatenation(int[] nums)
            {
                int[] ans = new int[(nums.Length) * 2];
                for (int i = 0; i < nums.Length; i++)
                {
                    ans[i] = nums[i];
                    ans[i + nums.Length] = nums[i];
                }
                return ans;
            }
        }
    }
}
