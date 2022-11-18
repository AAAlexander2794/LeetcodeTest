using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Problems
{
    /// <summary>
    /// Done
    /// </summary>
    internal class Problem_0263
    {
        public class Solution
        {
            public bool IsUgly(int n)
            {
                if (n == 0) return false;
                if (n == 1) return true;
                // 
                while (n % 2 == 0)
                {
                    n = n / 2;
                    //Console.WriteLine(n);
                }
                while (n % 3 == 0) { 
                    n = n / 3;
                    //Console.WriteLine(n);
                }
                while (n % 5 == 0) { n = n / 5;
                    //Console.WriteLine(n);
                }

                return n == 1;
            }
        }
    }
}
