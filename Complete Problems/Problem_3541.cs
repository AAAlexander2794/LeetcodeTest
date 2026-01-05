using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3541
    {
        public class Solution
        {
            public int MaxFreqSum(string s)
            {
                //
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                // 'a' - 97, 'z' - 122
                char[] chars = new char[26];
                //
                foreach (char c in s)
                {
                    chars[c - 97]++;
                }
                //
                int maxVowels = 0;
                int maxOther = 0;
                //
                for (int i = 0; i < chars.Length; i++) 
                {
                    char c = Convert.ToChar(i + 97);
                    if (vowels.Contains(c))
                    {
                        if (maxVowels < chars[i])
                        {
                            maxVowels = chars[i];
                        }
                    }
                    else
                    {
                        if (maxOther < chars[i])
                        {
                            maxOther = chars[i];
                        }
                    }
                }
                return maxVowels + maxOther;
            }
        }
    }
}
