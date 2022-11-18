using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Problems
{
    internal class Problem_0027
    {
        public class Solution
        {
            public int RemoveElement(int[] nums, int val)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == val) nums[i] = 101;
                }
                // После этого надо отсортировать
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            val = nums[i];
                            nums[i] = nums[j];
                            nums[j] = val;
                        }
                    }
                }
                // Вернуть надо место, после которого в массиве лишнее
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 101)
                    {
                        return i;
                    }
                }
                return nums.Length;
            }
        }
    }
}
