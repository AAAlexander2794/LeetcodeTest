using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3487
    {
        public class Solution
        {
            public int MaxSum(int[] nums)
            {
                HashSet<int> ints = new HashSet<int>();
                int sum = 0;
                int? maxOfMin = null;
                foreach (int num in nums)
                {
                    if (num > 0)
                    {
                        if (ints.Contains(num)) { continue; }
                        ints.Add(num);
                        sum += num;
                    }
                    else
                    {
                        if (maxOfMin == null) { maxOfMin = num; }
                        else
                        {
                            if (num > maxOfMin.Value) { maxOfMin = num; }
                        }
                    }
                }
                if (ints.Count == 0 && maxOfMin.HasValue) { return maxOfMin.Value; }
                return sum;
            }
        }
    }
}
