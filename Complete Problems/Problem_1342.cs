using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Not_Complete_Problems
{
    internal class Problem_1342
    {
        public int NumberOfSteps(int num)
        {
            int count = 0;
            while (num > 0)
            {
                if (num % 2 == 0) num = num / 2;
                else num--;
                count++;
            }
            return count;
        }
    }
}
