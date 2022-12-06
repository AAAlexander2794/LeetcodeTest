using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_2160
    {
        public class Solution
        {
            public int MinimumSum(int num)
            {
                int[] ar = new int[4];
                ar[0] = num % 10;
                ar[1] = num % 100 - ar[0];
                ar[2] = num % 1000 - ar[1] - ar[0];
                ar[3] = num - ar[2] - ar[1] - ar[0];

                ar[1] = ar[1] / 10;
                ar[2] = ar[2] / 100;
                ar[3] = ar[3] / 1000;

                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (ar[i] > ar[i + 1])
                        {
                            int a = ar[i];
                            ar[i] = ar[i + 1];
                            ar[i + 1] = a;
                        }
                    }
                }

                for(int i = 0; i < ar.Length; i++)
                {
                    Console.WriteLine(ar[i]);
                }

                int sum = ar[0] * 10 + ar[2] + ar[1] * 10 + ar[3];
                return sum;
            }

            public int MinimumSumSecondTry(int num)
            {
                int[] ar = new int[4];
                ar[0] = num % 10;
                ar[1] = num % 100 - ar[0];
                ar[2] = num % 1000 - ar[1] - ar[0];
                ar[3] = num - ar[2] - ar[1] - ar[0];

                ar[1] = ar[1] / 10;
                ar[2] = ar[2] / 100;
                ar[3] = ar[3] / 1000;

                Array.Sort(ar);
                                
                int sum = ar[0] * 10 + ar[2] + ar[1] * 10 + ar[3];
                return sum;
            }

            public int MinimumSumFirstTry(int num)
            {
                
                var ar = num.ToString().Select(x => Convert.ToInt32(x) - 48).ToList();
                ar.Sort();
                foreach (var item in ar)
                {
                    Console.WriteLine(item);
                }
                int sum = ar[0] * 10 + ar[2] + ar[1] * 10 + ar[3];
                return sum;
            }
        }
    }
}
