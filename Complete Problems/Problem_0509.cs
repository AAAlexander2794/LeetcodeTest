using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0509
    {
        public class Solution
        {
            public int Fib(int n)
            {
                
                int b = 1;
                if (n == 0) return 0;
                if (n == 1) return b;
                int f = b;
                for (int i = 2; i < n; i++)
                {

                    f = f + b;
                    b = f - b;
                }
                return f;
            }
        }
    }
}
