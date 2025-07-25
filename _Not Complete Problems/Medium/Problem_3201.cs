using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_3201
    {
        public class Solution
        {
            public int MaximumLength(int[] nums)
            {
                if (nums.Length == 2) { return 2; }
                //
                int result = 2;
                // 
                int num1;
                int num2;
                // Идем по элементам
                for (int i = 0; i < nums.Length; i++)
                {
                    // Берем первый элемент
                    num1 = nums[i];
                    /// <remarks>
                    /// К каждому элементу мы должны проверить все цепочки пар, то есть сначала берем соседний, 
                    /// узнаем их результат операции и ищем такие же, шагая по следующим элементам. Как дойдем
                    /// до конца, начинаем с того же элемента, но первую пару формируем не с соседним, а со следующим.
                    /// </remarks>
                    for (int k = i + 1; k < nums.Length; k++)
                    {
                        // Берем второй элемент пары
                        num2 = nums[k];
                        // Результат операции с парой
                        var res = (num1 + num2) % 2;
                        //
                        var subresult = 2;
                        /// <remarks>
                        /// Первая пара сформирована, результат операции получен, теперь проверяем остальные
                        /// элементы, первым элементом пары становится второй элемент.
                        /// </remarks>
                        // Теперь первый элемент пары - это второй элемент
                        num1 = num2;
                        // От следующего элемента (если есть) идем дальше
                        for (int j = k + 1; j < nums.Length; j++)
                        {
                            // Меняем второй элемент                        
                            num2 = nums[j];
                            // Если результаты совпали
                            if ((num1 + num2) % 2 == res)
                            {
                                subresult++;
                                // Текущий элемент становится первым в паре
                                num1 = num2;
                            }
                        }
                        //
                        if (subresult > result) { result = subresult; }
                    }
                }
                return result;
            }
        }
    }
}
