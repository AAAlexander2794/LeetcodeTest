using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0724
    {
        public class Solution
        {
            public int PivotIndex(int[] nums)
            {
                
                for (int i = 0; i < nums.Length; i++)
                {
                    int sumLeft = 0;
                    int sumRight = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sumLeft += nums[j];
                    }
                    for (int j = nums.Length - 1; j > i; j--)
                    {
                        sumRight += nums[j];
                    }
                    if (sumLeft == sumRight) return i;
                }
                return -1;
            }
        }
    }
}
