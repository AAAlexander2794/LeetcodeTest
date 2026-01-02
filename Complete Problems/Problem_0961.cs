using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0961
    {
        public class Solution
        {
            public int RepeatedNTimes(int[] nums)
            {
                HashSet<int> set = new HashSet<int>();
                for (int i = 0; i < nums.Length; i++) 
                {
                    if (set.Contains(nums[i]))
                    {
                        return nums[i];
                    }
                    else
                    {
                        set.Add(nums[i]);
                    }
                }
                return -1;
            }
        }
    }
}
