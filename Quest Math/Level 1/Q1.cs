using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Quest_Math.Level_1
{
    internal class Q1
    {
        public class Solution
        {
            public bool CanMakeArithmeticProgression(int[] arr)
            {
                Array.Sort(arr);
                int div = arr[1] - arr[0];
                for (int i = 1;  i < arr.Length - 1; i++) 
                {
                    if (arr[i + 1] - arr[i] != div)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
