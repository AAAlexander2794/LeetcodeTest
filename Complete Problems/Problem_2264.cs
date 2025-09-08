using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_2264
    {
        public class Solution
        {
            public string LargestGoodInteger(string num)
            {
                char? good = null;
                for (int i = 2; i < num.Length; i++) 
                {
                    if (num[i] == num[i - 1] && num[i] == num[i - 2])
                    {
                        if (good == null || good < num[i])
                        {
                            good = num[i];
                        }
                    }
                }
                if (good == null) { return ""; }
                else { return $"{good.Value}{good.Value}{good.Value}"; }
            }
        }
    }
}
