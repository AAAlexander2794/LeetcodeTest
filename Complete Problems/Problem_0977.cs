using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0977
    {
        public class Solution
        {
            public int[] SortedSquares(int[] nums)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    //if (nums[i] >= 0) break;
                    //nums[i] = Math.Abs(nums[i]);
                    nums[i] = nums[i] * nums[i];
                }
                Array.Sort(nums);

                return nums;


            }
        }
    }
}
