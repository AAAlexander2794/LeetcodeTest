using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0392
    {
        public class Solution
        {
            public bool IsSubsequence(string s, string t)
            {
                int offset = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    var flag = false;
                    for (int j = offset; j < t.Length; j++)
                    {
                        // Нашли букву
                        if (s[i] == t[j])
                        {
                            flag = true;
                            // Следующую букву будем искать от предыдущей
                            offset = j + 1;
                            //
                            break;
                        }
                    }
                    // Если за цикл не нашли букву, значит, ее там нет, все, прощай
                    if (!flag) return false;
                }
                return true;
            }
        }
    }
}
