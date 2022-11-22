using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0070
    {
        public class Solution
        {
            public int ClimbStairs(int n)
            {
                if (n == 1) return 1;
                int a = 1;
                int b = 2;
                int result = b;
                Console.Write($"{a} {b} {result}\n");
                for (int i = 3; i <= n; i++)
                {

                    result += a;
                    a = b;
                    b = result;
                    Console.Write($"{a} {b} {result}\n");

                }
                return result;
            }
        }
    }
}
