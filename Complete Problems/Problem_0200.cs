using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0200
    {
        public class Solution
        {
            public int NumIslands(char[][] grid)
            {
                var result = 0;
                //
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        result = result + ChekIsland(grid, i, j);
                        //Console.Write($"{grid[i][j]} ");
                    }
                    //Console.Write($"\n");
                }
                return result;
            }

            int ChekIsland(char[][] grid, int i, int j)
            {
                if (grid[i][j] != '1') return 0;
                grid[i][j] = '2';

                if (i - 1 >= 0 && grid[i - 1][j] == '1') {
                    //Console.Write($"up");
                    ChekIsland(grid, i - 1, j);
                }
                if (i + 1 < grid.Length && grid[i + 1][j] == '1') {
                    //Console.Write($"down");
                    ChekIsland(grid, i + 1, j);
                }
                if (j - 1 >= 0 && grid[i][j - 1] == '1') {
                    //Console.Write($"left");
                    ChekIsland(grid, i, j - 1);
                }
                if (j + 1 < grid[0].Length && grid[i][j + 1] == '1') {
                    //Console.Write($"right");
                    ChekIsland(grid, i, j + 1);
                }
                //Console.Write($" +1 ");
                return 1;

            }
        }
    }
}
