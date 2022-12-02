using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_2114
    {
        public class Solution
        {
            public int MostWordsFound(string[] sentences)
            {
                int max = 0;
                foreach (string sentence in sentences)
                {
                    string[] words = sentence.Split(' ');
                    if (words.Length > max) max = words.Length;
                }
                return max;
            }
        }
    }
}
