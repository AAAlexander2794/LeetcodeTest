using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_1046
    {
        public class Solution
        {
            public int LastStoneWeight(int[] stones)
            {
                var list = stones.ToList();
                while (list.Count > 1)
                {
                    var y = list.Max();
                    list.Remove(y);
                    var x = list.Max();
                    list.Remove(x);
                    if (y - x > 0) list.Add(y - x);
                }
                if (list.Count == 0) return 0;
                return list.First();
            }
        }
    }
}
