using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Problems
{
    /// <summary>
    /// Done
    /// </summary>
    /// <remarks>
    /// 2 <= nums.length <= 104
    ///-109 <= nums[i] <= 109
    ///-109 <= target <= 109
    ///Only one valid answer exists.
    /// </remarks>
    public partial class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // Последнее не берем
            for (int i = 0; i < nums.Length - 1; i++)
            {
                // Оставшиеся
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] {i, j};
                    }
                }
            }
            return new int[] {0, 0};
        }
    }
}
