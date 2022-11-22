using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0704
    {
        public class Solution
        {
            public int Search(int[] nums, int target)
            {
                if (target < nums[0] || target > nums[nums.Length - 1]) return -1;

                int start = 0;
                int end = nums.Length - 1;
                int med = 1;
                if (nums.Length < 3)
                {
                    for (int i = 0; i <= nums.Length; i++)
                    {
                        if (target == nums[i]) return i;
                    }
                    return -1;
                }
                while (end - start > 1)
                {
                    
                    if ((end - start) % 2 == 0) med = (end + start) / 2;
                    else med = ((end + start) - 1) / 2;
                    Console.WriteLine($"{start} {med} {end}");
                    if (target == nums[med]) return med;
                    if (target == nums[start]) return start;
                    if (target == nums[end]) return end;
                    if (target < nums[med])
                    {
                        end = med;
                    }
                    if (target > nums[med])
                    {
                        start = med;
                    }
                }
                return -1;
            }
        }
    }
}
