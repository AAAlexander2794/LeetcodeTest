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
    internal class Problem_0035
    {
        public class Solution
        {
            public int SearchInsert(int[] nums, int target)
            {
                //int count = 0;
                // 
                if (target <= nums[0]) return 0;
                // 
                for (int i = 1; i < nums.Length; i++)
                {
                    // Простейшее, если такой элемент в массиве есть или мы его только что прошли
                    if (nums[i] >= target) return i;
                    
                }
                // Возвращаем тупо
                return nums.Length;
            }
        }
    }
}
