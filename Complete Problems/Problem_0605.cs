using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0605
    {
        public class Solution
        {
            public bool CanPlaceFlowers(int[] flowerbed, int n)
            {
                if (n == 0) { return true; }
                for (int i = 0; i < flowerbed.Length; i++)
                {
                    if (flowerbed[i] == 1) { continue; }
                    if (i - 1 >= 0 && flowerbed[i - 1] == 1) { continue; }
                    if (i + 1 < flowerbed.Length && flowerbed[i + 1] == 1 ) { continue; }
                    //
                    n--;
                    if (n == 0) { return true; }
                    flowerbed[i] = 1;
                }
                return false;
            }
        }
    }
}
