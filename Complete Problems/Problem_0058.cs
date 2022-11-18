using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Problems
{
    internal class Problem_0058
    {
        public class Solution
        {
            public int LengthOfLastWord(string s)
            {
                var words = s.TrimEnd().Split(' ');
                return words[words.Length - 1].Trim().Length;
            }
        }
    }
}
