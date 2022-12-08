using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0283
    {
        public class Solution
        {
            public void MoveZeroes(int[] nums)
            {
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    if (nums[i] == 0)
                    {
                        for (int j = i; j < nums.Length - 1; j++)
                        {
                            if (nums[j + 1] == 0) break;
                            nums[j] = nums[j + 1];
                            nums[j + 1] = 0;
                        }
                    }
                }
            }
        }
    }
}
