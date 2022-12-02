using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0907
    {
        public class Solution
        {
            public int SumSubarrayMins(int[] arr)
            {
                var mod = 1000000007;
                //int sum = 0;

                
                // Специальная формула, столько раз встречается элемент массива в подмассивах,
                // первый и последний элементы встречаются меньше раз, общая формула:
                // weight[i] = weight[i - 1] + arr.Length - 1 - i + 1 - i
                int[] weights = Enumerable.Repeat(2 * (arr.Length - 1), arr.Length).ToArray();
                // Крайние заполнили отдельно
                weights[0] = arr.Length;
                weights[weights.Length - 1] = arr.Length;
                // Сортируем массив weights в соответствии с сортировкой arr 
                Array.Sort(arr, weights);
                //
                int sum = arr[0] * arr.Length;
                int min = arr[0];
                for (int i = 1; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i - 1])
                    sum += (arr[i] - arr[i - 1]) * 
                }
                //
                arr.ToList().Sort();
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int k = i; k < arr.Length; k++)
                    {
                        List<int> list = new List<int>();
                        for (int j = i; j <= k; j++)
                        {
                            list.Add(arr[j]);
                        }
                        //foreach (int j in list)
                        //{
                        //    Console.Write($"{j} ");
                        //}
                        Console.WriteLine($"{arr[i]} {list.Count}");
                        sum += list.Min();
                    }

                }
                return sum % mod;
            }

            public int SumSubarrayMinsLongTime(int[] arr)
            {
                var mod = 1000000007;
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int k = i; k < arr.Length; k++)
                    {
                        List<int> list = new List<int>();
                        for (int j = i; j <= k; j++)
                        {
                            list.Add(arr[j]);
                        }
                        //foreach (int j in list)
                        //{
                        //    Console.Write($"{j} ");
                        //}
                        //Console.WriteLine();
                        sum += list.Min();
                    }
                }
                return sum % mod;
            }
        }
    }
}
