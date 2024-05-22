using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_1768
    {
        public class Solution
        {
            public string MergeAlternately(string word1, string word2)
            {
                string result = "";
                int length = Math.Max(word1.Length, word2.Length);
                for (int i = 0; i < length; i++)
                {
                    if (i < word1.Length)
                    {
                        result += word1[i];
                    }
                    if (i < word2.Length)
                    {
                        result += word2[i];
                    }
                }    
                return result;
            }
        }
    }
}
