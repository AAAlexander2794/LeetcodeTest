using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3110
    {
        public class Solution
        {
            public int ScoreOfString(string s)
            {
                int score = 0;
                //
                for (int i = 0; i < s.Length - 1; i++)
                {
                    score += Math.Abs(s[i] - s[i + 1]);
                }
                //
                return score;
            }
        }
    }
}
