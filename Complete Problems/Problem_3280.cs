using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3280
    {
        public class Solution
        {
            public string ConvertDateToBinary(string date)
            {
                string[] arr = date.Split('-');
                string res = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    res += Convert.ToString(int.Parse(arr[i]), 2);
                    if (i != arr.Length - 1)
                    {
                        res += "-";
                    }
                }
                return res;                
            }
        }
    }
}
