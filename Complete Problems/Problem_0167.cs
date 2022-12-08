using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_0167
    {
        public class Solution
        {
            int[] result = new int[2];
            public int[] TwoSum(int[] numbers, int target)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    //if (numbers[i] > target) break;
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] + numbers[j] == target)
                        {
                            result[0] = i + 1;
                            result[1] = j + 1;
                            return result;
                        }
                    }
                }
                return result;
            }
        }
    }
}
