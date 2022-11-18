using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Problems
{
    /// <summary>
    /// Done
    /// </summary>
    internal class Problem_0026
    {
        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                if (nums.Length == 1) return 1;
                int a;
                // Пошли справа
                for (int i = nums.Length - 1; i >= 1; i--)
                {
                    // Берем левее
                    a = nums[i-1];
                    // Если левее такое же, то наше ставим выше максимума
                    if (a == nums[i]) nums[i] = 101;
                }
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write($"{nums[i]} ");
                }
                Console.WriteLine("\n***");
                // После этого надо отсортировать
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            a = nums[i];
                            nums[i] = nums[j];
                            nums[j] = a;
                        }
                    }
                }
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write($"{nums[i]} ");
                }
                Console.WriteLine("\n***");
                // Вернуть надо место, после которого в массиве лишнее
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 101) 
                    {
                        Console.WriteLine($"stop {i}");
                        return i;
                    }
                }
                return nums.Length;
            }
        }
    }
}
