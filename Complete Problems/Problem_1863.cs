using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_1863
    {
        public class Solution
        {
            public int SubsetXORSum(int[] nums)
            {
                int sum = 0;
                // Смещаем 1 на длину массива - получаем количество масок для перебора всех вариантов
                int maxMask = 1 << nums.Length;
                //
                for (int mask = 0; mask < maxMask; mask++)
                {
                    //
                    int xorTotal = 0;
                    // Перебираем все элементы массива внутри каждой маски
                    for (int i = 0; i < nums.Length; i++)
                    {
                        // Определяем позицию элемента в маске, например 00001000
                        int iMaskPosition = 1 << i;
                        // Если номер элемента попал в маску, то поразрядное умножение даст число
                        if ( (mask & iMaskPosition) != 0)
                        {
                            xorTotal = xorTotal ^ nums[i];
                        }
                    }
                    //
                    sum += xorTotal;
                }
                //
                return sum;
            }
        }
    }
}
