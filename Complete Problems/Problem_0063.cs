using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_0063
    {
        public class Solution
        {
            public int UniquePathsWithObstacles(int[][] obstacleGrid)
            {
                if (obstacleGrid[0][0] == 1) return 0;

                for (int i = 0; i < obstacleGrid.Length; i++)
                {
                    for (int j = 0; j < obstacleGrid[i].Length; j++)
                    {
                        if (obstacleGrid[i][j] == 1)
                        {
                            obstacleGrid[i][j] = -1;
                            continue;
                        }
                        if (i == 0 && j == 0) obstacleGrid[i][j] = 1;
                        if (i > 0 && obstacleGrid[i - 1][j] != -1) obstacleGrid[i][j] += obstacleGrid[i - 1][j];
                        if (j > 0 && obstacleGrid[i][j - 1] != -1) obstacleGrid[i][j] += obstacleGrid[i][j - 1];
                        Console.Write($"{i}-{j} {obstacleGrid[i][j]} ");
                    }
                    Console.WriteLine();
                }
                if (obstacleGrid[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1] == -1) return 0;
                return obstacleGrid[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1];
            }
        }

        
    }
}
