using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Quest_Math.Level_1
{
    internal class Q3
    {
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                if (x < 0) { return false; }
                if (x >= 0 && x < 10) { return true; }
                //
                string str = x.ToString();
                int left = 0;
                int right = str.Length - 1;
                //
                while (left < right) 
                {
                    if (str[left] != str[right])
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
                //
                return true;
            }
        }
    }
}
