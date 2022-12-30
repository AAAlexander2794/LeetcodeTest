using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_1431
    {
        public class Solution
        {
            public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
            {
                var list = new List<bool>();
                var max = 0;
                for (int i = 0; i < candies.Length; i++)
                {
                    if (candies[i] > max) max = candies[i];
                }
                for (int i = 0; i < candies.Length; i++)
                {
                    list.Add(candies[i] + extraCandies >= max);
                }
                return list;
            }
        }
    }
}
