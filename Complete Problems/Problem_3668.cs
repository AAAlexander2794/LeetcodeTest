using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3668
    {
        public class Solution
        {
            public int[] RecoverOrder(int[] order, int[] friends)
            {
                int[] res = new int[friends.Length];
                int pos = 0;
                foreach (int id in order)
                {
                    if (friends.Contains(id)) 
                    {
                        res[pos] = id;
                        pos++;
                    }
                }
                return res;
            }
        }
    }
}
