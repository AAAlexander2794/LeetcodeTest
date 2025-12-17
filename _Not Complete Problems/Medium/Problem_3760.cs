using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_3760
    {
        public class Solution
        {
            public int MaxDistinct(string s)
            {
                return s.Distinct().Count();
            }
        }
    }
}
