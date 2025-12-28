using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_1351
    {
        public class Solution
        {
            public int CountNegatives(int[][] grid)
            {
                int count = 0;
                int length1 = grid.Length;
                int length2 = grid[0].Length;
                for (int i = length1 - 1; i >= 0; i--)
                {
                    for (int j = length2 - 1; j >= 0; j--)
                    {
                        if (grid[i][j] < 0)
                        {
                            count++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                return count;
            }
        }
    }
}
