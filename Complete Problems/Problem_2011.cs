using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_2011
    {
        public class Solution
        {
            public int FinalValueAfterOperations(string[] operations)
            {
                int x = 0;
                for (int i = 0; i < operations.Length; i++)
                {
                    switch (operations[i])
                    {
                        case "X++":
                            x++;
                            break;
                        case "++X":
                            ++x;
                            break;
                        case "X--":
                            x--;
                            break;
                        case "--X":
                            --x;
                            break;
                    }
                }
                return x;
            }
        }
    }
}
