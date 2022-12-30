using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_0542
    {
        public class Solution
        {
            public int[][] UpdateMatrix(int[][] mat)
            {
                int[][] matrix = new int[mat.Length][];
                // В прямом порядке
                for (int i = 0; i < mat.Length; i++)
                {
                    matrix[i] = new int[mat[i].Length];
                    for (int j = 0; j < mat[i].Length; j++)
                    {
                        Console.Write($"{mat[i][j]} ");
                        // Если эта ячейка 0, ничего не делаем
                        if (mat[i][j] == 0) continue;
                        //
                        matrix[i][j] = -1;
                        // Если выше есть
                        if (i - 1 >= 0)
                        {
                            // Если выше посчитана, то сюда пишем
                            if (matrix[i - 1][j] != -1) matrix[i][j] = matrix[i - 1][j] + 1;
                        }
                        //
                        if (j - 1 >= 0)
                        {
                            //
                            if (matrix[i][j - 1] != -1)
                            {
                                if (matrix[i][j] == -1) matrix[i][j] = matrix[i][j - 1] + 1;
                                else
                                    matrix[i][j] = Math.Min(matrix[i][j], matrix[i][j - 1] + 1);
                            }
                            continue;
                        }
                    }
                    Console.WriteLine();
                }
                // Обратно
                for (int i = mat.Length - 1; i >= 0; i--)
                {
                    for (int j = mat[i].Length - 1; j >= 0; j--)
                    {
                        // Если эта ячейка 0
                        if (mat[i][j] == 0) continue;
                        //
                        if (i + 1 < mat.Length)
                        {
                            //
                            if (matrix[i][j] == -1) matrix[i][j] = matrix[i + 1][j] + 1;
                            else
                            matrix[i][j] = Math.Min(matrix[i][j], matrix[i + 1][j] + 1);
                        }
                        //
                        if (j + 1 < mat[i].Length)
                        {
                            //
                            if (matrix[i][j] == -1) matrix[i][j] = matrix[i][j + 1] + 1;
                            else
                            matrix[i][j] = Math.Min(matrix[i][j], matrix[i][j + 1] + 1);
                        }
                    }
                }
                return matrix;
            }
        }


        
    }
}
