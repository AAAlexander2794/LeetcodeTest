using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Quest_Math.Level_1.Quiz
{
    internal class Q1
    {
        public class Solution
        {
            public int Reverse(int x)
            {
                int res = 0;
                bool minus = false;
                if (x < 0)
                {
                    minus = true;
                    x = -x;
                }
                var arr = x.ToString().ToArray();
                if (arr.Length > 31)
                {
                    return 0;
                }
                int left = 0;
                int right = arr.Length - 1;
                while (left < right)
                {
                    var some = arr[left];
                    arr[left] = arr[right];
                    arr[right] = some;
                    left++;
                    right--;
                }
                res = int.Parse(arr.ToString());
                if (minus)
                {
                    res = -res;
                }
                return res;
            }
        }
    }
}
