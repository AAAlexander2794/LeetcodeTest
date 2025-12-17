using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Quest_Math.Level_1
{
    internal class Q2
    {
        public class Solution
        {
            public int PivotInteger(int n)
            {
                int sumLeft = 0;
                for (int i = 1; i <= n; i++)
                {
                    sumLeft += i;
                }
                int sumRigth = n;
                //
                if (sumLeft == sumRigth) { return sumLeft; }
                //
                for (int i = n - 1; i >= 1; i--)
                {
                    sumLeft -= (i + 1);
                    sumRigth += i;
                    if (sumLeft == sumRigth) { return i; }
                }
                //
                return -1;
            }
        }
    }
}
