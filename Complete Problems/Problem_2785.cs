using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_2785
    {
        public class Solution
        {
            public string SortVowels(string s)
            {
                char[] vowels = ['A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u'];
                int[] vowelCounts = new int[vowels.Length];

                char[] chars = s.ToCharArray();
                

                foreach(char c in chars)
                {
                    for (int i = 0; i < vowels.Length; i++)
                    {
                        if (c == vowels[i])
                        {
                            vowelCounts[i]++;
                        }
                    }
                }


                for (int i = 0; i < chars.Length; i++)
                {
                    if (vowels.Contains(char.ToLower(chars[i])))
                    {
                        for (int j = 0; j < vowels.Length; j++)
                        {
                            if (vowelCounts[j] > 0)
                            {
                                chars[i] = vowels[j];
                                vowelCounts[j]--;
                                break;
                            }
                        }
                    }
                }
                return new string(chars);
            }
        }
    }
}
