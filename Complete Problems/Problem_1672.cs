using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Not_Complete_Problems
{
    internal class Problem_1672
    {
        public class Solution
        {
            public int MaximumWealth(int[][] accounts)
            {
                int maxWealth = 0;
                for (int i = 0; i < accounts.Length; i++)
                {
                    int curWealth = 0;
                    for (int j = 0; j < accounts[i].Length; j++)
                    {
                        curWealth += accounts[i][j];
                    }
                    if (curWealth > maxWealth) maxWealth = curWealth;
                }
                return maxWealth;
            }
        }
    }
}
