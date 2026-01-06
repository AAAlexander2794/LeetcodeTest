using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_2161
    {
        public class Solution
        {
            public int[] PivotArray(int[] nums, int pivot)
            {
                List<int> beforePivot = new List<int>();
                List<int> inPivot = new List<int>();
                List<int> afterPivot = new List<int>();
                foreach (int num in nums)
                {
                    if (num < pivot)
                    {
                        beforePivot.Add(num);
                        continue;
                    }
                    if (num > pivot)
                    {
                        afterPivot.Add(num);
                        continue;
                    }
                    inPivot.Add(num);
                }
                int[] res = new int[nums.Length];
                int i = 0;
                foreach (int num in beforePivot)
                {
                    res[i++] = num;
                }
                foreach (int num in inPivot)
                {
                    res[i++] = num;
                }
                foreach (int num in afterPivot)
                {
                    res[i++] = num;
                }
                return res;
            }
        }
    }
}
