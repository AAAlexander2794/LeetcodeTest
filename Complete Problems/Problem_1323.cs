using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_1323
    {
        public class Solution
        {
            public int Maximum69Number(int num)
            {
                char[] arr = num.ToString().ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == '6')
                    {
                        arr[i] = '9';
                        break;
                    }
                }
                return int.Parse(arr);
            }
        }
    }
}
