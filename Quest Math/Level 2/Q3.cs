using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Quest_Math.Level_2
{
    /// <summary>
    /// Q3. Self Dividing Numbers
    /// </summary>
    internal class Q3
    {
        public class Solution
        {
            public IList<int> SelfDividingNumbers(int left, int right)
            {
                List<int> result = new List<int>();
                for (int i = left; i <= right; i++)
                {
                    if (IsSelfDivided(i))
                    {
                        result.Add(i);
                    }
                }
                return result;
            }

            private bool IsSelfDivided(int digit)
            {
                int n = digit;
                while (n > 0)
                {
                    int a = n % 10;
                    if (a == 0) { return  false; }
                    if (digit % a != 0) { return  false; }
                    n = (n - a) / 10;
                }
                return true;
            }
        }
    }
}
