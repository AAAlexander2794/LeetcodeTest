using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Not_Complete_Problems
{
    internal class Problem_1337
    {
        public class Solution
        {
            public int[] KWeakestRows(int[][] mat, int k)
            {
                int[] KWeakestRows = new int[k];
                for (int i = 0; i < KWeakestRows.Length; i++)
                {
                    KWeakestRows[i] = -1;
                }
                // Сначала первый столбец
                for (int j = 0; j < mat[0].Length; j++)
                {
                    Console.WriteLine($"\n{j} column");
                    // Сначала первая строка
                    for (int i = 0; i < mat.Length; i++)
                    {
                        Console.Write($"[{i}] ");
                        //// Если эта строка уже в списке слабых, мы ее не проверяем
                        //if (KWeakestRows.Contains(i))
                        //{
                        //    Console.Write("* ");
                        //    continue;
                        //}

                        if (mat[i][j] == 0 && !KWeakestRows.Contains(i))
                        {
                            // Вставляем в начало массива без лишнего счетчика
                            KWeakestRows[KWeakestRows.Length - k] = i;
                            k--;
                            Console.Write($"{i} ");
                        }
                        //
                        if (k == 0) return KWeakestRows;
                        //// Если это уже последний столбец, а место в списке слабых осталось, то заполняем тупо подряд
                        //if (j == mat[0].Length - 1 && k > 0 && !KWeakestRows.Contains(i))
                        //{
                        //    KWeakestRows[KWeakestRows.Length - k] = i;
                        //    k--;
                        //    Console.Write($"{i} ");
                        //}
                        ////
                        //if (k == 0) return KWeakestRows;
                    }
                }
                Console.WriteLine($"k {k}");
                
                if (k > 0)
                {
                    for (int i = 0; i < mat.Length; i++)
                    {
                        if (!KWeakestRows.Contains(i))
                        {
                            KWeakestRows[KWeakestRows.Length - k] = i;
                            k--;
                        }
                        if (k == 0) return KWeakestRows;
                    }
                }
                return KWeakestRows;
            }
        }
    }
}
