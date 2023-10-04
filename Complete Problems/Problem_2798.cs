using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_2798
    {
        public class Solution
        {
            public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
            {
                int count = 0;
                for (int i = 0; i < hours.Length; i++)
                {
                    if (hours[i] >= target)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
