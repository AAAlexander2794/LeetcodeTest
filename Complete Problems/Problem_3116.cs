using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3116
    {
        public class Solution
        {
            public int FindClosest(int x, int y, int z)
            {
                if (Math.Abs(x - z) < Math.Abs(y - z))
                {
                    return 1;
                }
                else if (Math.Abs(x - z) > Math.Abs(y - z))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }

            }
        }
    }
}
