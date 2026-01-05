using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3701
    {
        public class Solution
        {
            public int AlternatingSum(int[] nums)
            {
                int digit = 1;
                int sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i] * digit;
                    digit = -digit;
                }
                return sum;
            }
        }
    }
}
