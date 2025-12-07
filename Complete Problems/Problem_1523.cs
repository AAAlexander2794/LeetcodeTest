using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_1523
    {
        public class Solution
        {
            public int CountOdds(int low, int high)
            {
                if (low % 2 == 1 && high % 2 == 1)
                {
                    return (high - low) / 2 + 1;
                }
                if (low % 2 == 0 && high % 2 == 0)
                {
                    return (high - low) / 2;
                }
                return (high - low + 1) / 2;
            }
        }
    }
}
