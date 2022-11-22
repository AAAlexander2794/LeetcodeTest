using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0278
    {
       

        public class Solution
        {
            public int FirstBadVersion(int n)
            {
                if (n < 3 ) 
                {
                    if (IsBadVersion(1)) return 1;
                    else return 2;
                }
                int start = 1;
                while (n - start > 1)
                {
                    int med;
                    if ((n - start) % 2 == 0) med = (n + start) / 2;
                    else med = (n + start - 1) / 2;
                    Console.WriteLine($"{start} {med} {n}");
                    if (IsBadVersion(med)) n = med;
                    else start = med;
                }
                // n - точно плохая версия
                for (int i = n - 1; i > start; i--)
                {
                    if (!IsBadVersion(i)) return i + 1;
                }
                return start + 1;
            }

            bool IsBadVersion(int version)
            {
                return version == 4;
            }
        }
    }
}
