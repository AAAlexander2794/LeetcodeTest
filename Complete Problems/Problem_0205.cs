using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0205
    {
        public class Solution
        {
            public bool IsIsomorphic(string s, string t)
            {
                if (s.Length == 1) return true;
                //
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        // Если в любом из слов две буквы совпали
                        if (s[i] == s[j] || t[i] == t[j])
                        {
                            // Если совпали сразу в обеих словах, продолжаем, иначе возвращаем ложь
                            if (s[i] == s[j] && t[i] == t[j]) continue;
                            else return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}
