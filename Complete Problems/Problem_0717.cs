using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0717
    {
        public class Solution
        {
            public bool IsOneBitCharacter(int[] bits)
            {
                int i = 0;
                while (i < bits.Length - 1)
                {
                    if (bits[i] == 1) { i += 2; }
                    else { i++; }
                }
                if (i == bits.Length) { return false; }
                return true;
            }
        }
    }
}
