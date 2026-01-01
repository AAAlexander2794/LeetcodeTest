using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0066
    {
        public class Solution
        {
            public int[] PlusOne(int[] digits)
            {
                bool addDigit = false;
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    if (digits[i] == 9)
                    {
                        digits[i] = 0;
                        if (i == 0)
                        {
                            addDigit = true;
                        }
                        continue;
                    }
                    else
                    {
                        digits[i]++;
                        break;
                    }
                }
                if (addDigit)
                {
                    int[] res = new int[digits.Length + 1];
                    res[0] = 1;
                    for (int i = 1; i < res.Length; i++)
                    {
                        res[i] = digits[i - 1];
                    }
                    return res;
                }
                return digits;
            }
        }
    }
}
