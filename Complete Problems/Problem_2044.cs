using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_2044
    {
        public class Solution
        {
            public int CountMaxOrSubsets(int[] nums)
            {
                int max = 0;
                int count = 0;
                // Смещаем 1 на длину массива - получаем количество масок для перебора всех вариантов
                for (int mask = 0; mask < (1 << nums.Length); mask++)
                {
                    //List<int> subset = new List<int>();
                    int bitwiseOr = 0;
                    // Перебираем все элементы массива внутри каждой маски
                    for (int i = 0; i < nums.Length; i++)
                    {
                        // Определяем позицию элемента в маске, например 00001000
                        int iMaskPosition = 1 << i;
                        // Если номер элемента попал в маску, то поразрядное умножение даст число
                        if ((mask & iMaskPosition) != 0)
                        {
                            //subset.Add(nums[i]);
                            bitwiseOr |= nums[i];
                        }
                    }
                    if (bitwiseOr > max)
                    {
                        max = bitwiseOr;
                        count = 1;
                    }
                    else if (bitwiseOr == max)
                    {
                        count++;
                    }
                    else { }
                }
                return count;
            }
        }
    }
}
