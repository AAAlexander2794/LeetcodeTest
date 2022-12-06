using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_1689
    {
        public class Solution
        {
            public int MinPartitions(string n)
            {
                int result = 0;
                foreach (var s in n)
                {
                    var digit = int.Parse(s.ToString());
                    if (digit > result) result = digit; 
                }
                return result;
            }
        }
    }
}
