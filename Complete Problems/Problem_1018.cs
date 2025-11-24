using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_1018
    {
        public class Solution
        {
            public IList<bool> PrefixesDivBy5(int[] nums)
            {
                List<bool> bools = new List<bool>();
                int number = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    number = number * 2 + nums[i];
                    bools.Add(number % 5 == 0);
                    number = number % 5;
                }
                return bools;
            }
        }
    }
}
