using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_0695
    {
        public class Solution
        {
            public int MaxAreaOfIsland(int[][] grid)
            {
                int maxArea = 0;
                // Идем по всем
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        var area = Fill(grid, i, j);
                        if (area > maxArea) maxArea = area;
                    }
                }
                return maxArea;
            }

            int Fill(int[][] grid, int i, int j)
            {
                if (grid[i][j] == 0 || grid[i][j] == -1) return 0;
                // Уже площадь 1
                int area = 1;
                // Красим, что прошли
                grid[i][j] = -1;
                // Вверх
                if (i - 1 >= 0 && grid[i - 1][j] == 1) area += Fill(grid, i - 1, j);
                if (i + 1 < grid.Length && grid[i + 1][j] == 1) area += Fill(grid, i + 1, j);
                // Влево
                if (j - 1 >= 0 && grid[i][j - 1] == 1) area += Fill(grid, i, j - 1);
                if (j + 1 < grid[i].Length && grid[i][j + 1] == 1) area += Fill(grid, i, j + 1);

                return area;
            }
        }
    }
}
