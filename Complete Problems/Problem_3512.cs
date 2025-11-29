using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3512
    {
        public class Solution
        {
            public int MinOperations(int[] nums, int k)
            {
                int sum = 0;
                foreach (int i in nums) 
                {
                    sum = (sum + i) % k;
                }
                return sum;
            }
        }
    }
}
