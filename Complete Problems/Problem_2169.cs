using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_2169
    {
        public class Solution
        {
            public int CountOperations(int num1, int num2)
            {
                int count = 0;
                while (num1 != 0 && num2 != 0)
                {
                    if (num1 >= num2)
                    {
                        num1 -= num2;
                    }
                    else
                    {
                        num2 -= num1;
                    }
                    count++;
                }
                return count;
            }
        }
    }
}
