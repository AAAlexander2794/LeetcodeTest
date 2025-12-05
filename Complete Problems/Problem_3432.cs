using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3432
    {
        public class Solution
        {
            public int CountPartitions(int[] nums)
            {
                int countEven = 0;
                //
                int sumLeft = 0;
                int sumRight = 0;
                // Ищем сумму справа
                for (int i = 0; i < nums.Length; i++)
                {
                    sumRight += nums[i];
                }
                //
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    sumLeft += nums[i];
                    sumRight -= nums[i];
                    //
                    if ((sumLeft + sumRight) % 2 == 0)
                    {
                        countEven++;
                    }
                }
                return countEven;
            }
        }
    }
}
