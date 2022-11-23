using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0062
    {
        public class Solution
        {
            public int UniquePaths(int m, int n)
            {
                int[,] sum = new int[m,n];
                sum[0, 0] = 1;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i - 1 >= 0) sum[i, j] += sum[i - 1, j];
                        if (j - 1 >= 0) sum[i, j] += sum[i, j - 1]; 
                    }
                }
                return sum[m - 1, n - 1];
            }

            //int Fill(int i, int j, int m, int n)
            //{
            //    Console.Write($"{i} {j} | ");
            //    int sum = 0;
            //    if (i < m)
            //    {
            //        sum += Fill(i + 1, j, m, n);
            //    }
            //    if (j < n)
            //    {
            //        sum += Fill(i, j + 1, m, n);
            //    }
            //    return sum;
            //}
        }
    }
}
