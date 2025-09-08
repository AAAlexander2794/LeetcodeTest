using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3467
    {
        public class Solution
        {
            public int[] TransformArray(int[] nums)
            {
                int evenCount = 0;
                int oddCount = 0;
                foreach (int i in nums)
                {
                    if (i % 2 == 0) { evenCount++; }
                    else { oddCount++; }
                }
                int[] result = new int[evenCount + oddCount];
                for (int i = 0; i < evenCount; i++)
                {
                    result[i] = 0;
                }
                for (int i = evenCount; i < result.Length; i++)
                {
                    result[i] = 1;
                }
                return result;
            }
        }
    }
}
