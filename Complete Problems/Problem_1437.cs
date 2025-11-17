using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_1437
    {
        public class Solution
        {
            public bool KLengthApart(int[] nums, int k)
            {
                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 1)
                    {
                        if (count > 0) { return false; }
                        count = k;
                    }
                    else
                    {
                        count--;
                    }
                }
                return true;
            }
        }
    }
}
