using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3289
    {
        public class Solution
        {
            public int[] GetSneakyNumbers(int[] nums)
            {
                int[] res = { -1, -1};
                HashSet<int> set = new HashSet<int>();
                foreach (int num in nums)
                {
                    if (set.Contains(num))
                    {
                        for (int i = 0; i < res.Length; i++)
                        {
                            if (res[i] == -1) 
                            { 
                                res[i] = num;
                                break;
                            }
                        }
                    }
                    else
                    {
                        set.Add(num);
                    }
                }
                return res;
            }
        }
    }
}
