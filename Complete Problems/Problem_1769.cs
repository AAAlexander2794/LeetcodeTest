using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_1769
    {
        public class Solution
        {
            public int[] MinOperations(string boxes)
            {
                int[] arr = new int[boxes.Length];
                for (int i = 0; i < boxes.Length; i++)
                {
                    arr[i] = (int)char.GetNumericValue(boxes[i]);
                }
                int[] ans = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        //if (arr[j] == 0 || j == i) { continue; }
                        ans[i] += Math.Abs(i - j) * arr[j];
                    }
                }
                return ans;
            }
        }
    }
}
