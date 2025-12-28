using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Quest_Math.Level_3
{
    /// <summary>
    /// Q1. Permutation Sequence
    /// </summary>
    internal class Q1
    {
        public class Solution
        {
            public string GetPermutation(int n, int k)
            {
                //
                int[] arr = new int[n];
                for (int i = 0;  i < arr.Length; i++)
                {
                    arr[i] = i + 1;
                }
                // Позиция цифры будущего числа
                int pos = 0;
                // Размер первого блока
                int block = n - 1;

                for (int i = 0; i < n; i++)
                {
                    // Пока шагов больше или равно, чем размер блока
                    while (k >= n - 1 - i)
                    {
                        arr[i]++;
                        k -= n - 1 - i;
                    }
                }

                // Пока шаги не кончатся
                while (k > 0)
                {
                    /// <remarks>
                    /// Каждая позиция цифры отсортирована. Одна и та же цифра на первой позиции идет (n-1) раз.
                    /// На следующей позиции одна и та же цифра идет (n-2) раз, потому что одна из 9 цифр уже на первой позиции.
                    /// </remarks>

                    // Если шагов больше, чем размер блока
                    if (k >= block)
                    {
                        arr[pos]++;
                        k -= block;
                        continue;
                    }
                    else
                    {
                        block--;
                        pos++;
                    }
                }
                string res = "";
                foreach (int i in arr) 
                {
                    res += arr[i];
                }
                //
                return res;
            }

            public string GetPermutation1(int n, int k)
            {
                //
                int[] arr = new int[n];
                // Позиция цифры будущего числа
                int pos = 0;
                // Пока доступные цифры не кончатся
                while (n > 1)
                {
                    /// <remarks>
                    /// Каждая позиция цифры отсортирована. Одна и та же цифра на первой позиции идет (n-1) раз.
                    /// На следующей позиции одна и та же цифра идет (n-2) раз, потому что одна из 9 цифр уже на первой позиции.
                    /// </remarks>


                    // Столько чисел прошли до блока
                    int a = k % (n - 1);
                    // Количество шагов по блокам чисел
                    int steps = (k - a) / (n - 1);
                    // Осталось пройти чисел
                    k = a;

                    int digit = 1;
                    // Перебираем цифры по порядку по шагам
                    for (int j = 1; j <= steps; j++)
                    {
                        // Если цифра уже есть в массиве, то ее не считаем за шаг (делаем на шаг больше)
                        if (arr.Contains(j)) { digit++; }
                    }

                    arr[pos] = digit + steps;
                    pos++;
                    // Уменьшаем количество 
                    n--;
                }
                string res = "";
                foreach (int i in arr)
                {
                    res += arr[i];
                }
                //
                return res;
            }
        }
    }
}
