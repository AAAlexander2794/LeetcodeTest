using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Hard
{
    internal class Problem_0980
    {
        public class Solution
        {
            private short count = 0;
            long all;

            public int UniquePathsIII(int[][] grid)
            {
                int[] start = new int[] { 0, 0 };
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (grid[i][j] == -1) continue;
                        else all++;
                        if (grid[i][j] == 1)
                        {
                            start[0] = i;
                            start[1] = j;
                        }
                    }
                }
                Console.WriteLine(all);
                Fill(grid, start[0], start[1]);
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        Console.Write(grid[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                return count;
            }

            private int[][] Fill(int[][] grid, int i, int j, long step = 0)
            {
                // Отмечаем шаг
                step++;
                Console.WriteLine($"{step} {i}-{j} {grid[i][j]}");
                // Если отшагали все и на финише
                if (step == all && grid[i][j] == 2) count++;
                // Красим в препятствие
                grid[i][j] = -1;
                //
                
                // Вверх
                if (i > 0 && grid[i - 1][j] != -1)
                {
                    var copy = grid.Select(x => x.ToArray()).ToArray();
                    Fill(copy, i - 1, j, step);
                }
                // Вниз
                if (i < grid.Length - 1 && grid[i + 1][j] != -1)
                {
                    var copy = grid.Select(x => x.ToArray()).ToArray();
                    Fill(copy, i + 1, j, step);
                }
                // Влево
                if (j > 0 && grid[i][j - 1] != -1)
                {
                    var copy = grid.Select(x => x.ToArray()).ToArray();
                    Fill(copy, i, j - 1, step);
                }
                // Вправо
                if (j < grid[0].Length - 1 && grid[i][j + 1] != -1)
                {
                    var copy = grid.Select(x => x.ToArray()).ToArray();
                    Fill(copy, i, j + 1, step);
                }

                return grid;

            }
        }
    }
}
