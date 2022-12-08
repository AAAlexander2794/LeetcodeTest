using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_0189
    {
        public class Solution
        {
            public void Rotate(int[] nums, int k)
            {
                if (nums == null || k == 0 || k == nums.Length) return;

                while (k > nums.Length) k -= nums.Length;

                var list = nums.ToList();
                var n = list.Count - 1;

                var part = list.GetRange(n - k + 1, k);
                list.RemoveRange(n - k + 1, k);
                list.InsertRange(0, part);

                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = list[i];
                    Console.Write($"{nums[i]} ");
                }
            }
        }
    }
}
