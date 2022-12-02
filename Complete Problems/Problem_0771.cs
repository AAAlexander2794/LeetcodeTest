using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0771
    {
        public class Solution
        {
            public int NumJewelsInStones(string jewels, string stones)
            {
                int count = 0;
                foreach (var s in stones)
                {
                    if (jewels.Contains(s)) count++;
                }
                return count;
            }
        }
    }
}
